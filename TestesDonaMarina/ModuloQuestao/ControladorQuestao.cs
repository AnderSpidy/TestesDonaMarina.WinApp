using System.Collections.Generic;
using System.Windows.Forms;
using TestesDonaMarina.Compartilhado;
using TestesDonaMarina.Dominio.ModuloDisciplina;
using TestesDonaMarina.Dominio.ModuloMateria;
using TestesDonaMarina.Dominio.ModuloQuestao;
using TestesDonaMarina.Dominio.ModuloTeste;

namespace TestesDonaMarina.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private readonly IRepositorioQuestao repositorioQuestao;
        private readonly IRepositorioDisciplina repositorioDisciplina;
        private readonly IRepositorioMateria repositorioMateria;
        private readonly IRepositorioTeste repositorioTeste;

        private TabelaQuestaoControl tabelaQuestoes;

        public ControladorQuestao(IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina,IRepositorioTeste repositorioTeste)
        {

            this.repositorioQuestao = repositorioQuestao;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMateria;
            this.repositorioTeste = repositorioTeste;
        }



        public override void Inserir()
        {
            
            TelaCadastroQuestaoForm tela = new TelaCadastroQuestaoForm(repositorioDisciplina, repositorioMateria);
            tela.Questao = new Questao();

            tela.GravarRegistro = repositorioQuestao.Inserir;

            DialogResult resultado = tela.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                List<Alternativa> alternativas = tela.AlternativasAdicionadas;
                repositorioQuestao.AdicionarAlternativas(tela.Questao, alternativas);
                CarregarQuestoes();
            }
        }
        public override void Editar()
        {
            Questao questaoSelecionada = ObtemQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma questão primeiro",
                "Edição de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroQuestaoForm tela = new TelaCadastroQuestaoForm(repositorioDisciplina, repositorioMateria);

            tela.Questao = questaoSelecionada;

            tela.GravarRegistro = repositorioQuestao.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                List<Alternativa> alternativas = tela.AlternativasAdicionadas;
                repositorioQuestao.AdicionarAlternativas(tela.Questao, alternativas);
                CarregarQuestoes();
            }
        }

        public override void Excluir()
        {
            Questao questaoSelecionada = ObtemQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma questão primeiro",
                "Exclusão de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var testes = repositorioTeste.SelecionarTodos();

            foreach (var questoes in testes)
            {
                foreach (var questao in questoes.Questoes)
                {
                    if (questaoSelecionada.Enunciado == questao.Enunciado)
                    {
                        MessageBox.Show("Esta questão está atrelada a um teste e não pode ser excluída",
                        "Exclusão de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a questão?",
                "Exclusão de Questões", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioQuestao.Excluir(questaoSelecionada);
                CarregarQuestoes();
            }

        }



        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxQuestao();
        }

        public override UserControl ObtemListagem()
        {
            tabelaQuestoes = new TabelaQuestaoControl();

            CarregarQuestoes();

            return tabelaQuestoes;
        }

        private Questao ObtemQuestaoSelecionada()
        {
            var numero = tabelaQuestoes.ObtemNumeroQuestaoSelecionada();

            return repositorioQuestao.SelecionarPorNumero(numero);
        }
        private void CarregarQuestoes()
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();
            tabelaQuestoes.AtualizarRegistros(questoes);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando Questões");

        }

       
    }
}
