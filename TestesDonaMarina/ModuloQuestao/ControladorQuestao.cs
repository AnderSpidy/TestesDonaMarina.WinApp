using System.Collections.Generic;
using System.Windows.Forms;
using TestesDonaMarina.Compartilhado;
using TestesDonaMarina.Dominio.ModuloDisciplina;
using TestesDonaMarina.Dominio.ModuloMateria;
using TestesDonaMarina.Dominio.ModuloQuestao;

namespace TestesDonaMarina.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private readonly IRepositorioQuestao repositorioQuestao;
        private readonly IRepositorioDisciplina repositorioDisciplina;
        private readonly IRepositorioMateria repositorioMateria;

        private TabelaQuestaoControl tabelaQuestoes;

        public ControladorQuestao(IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {

            this.repositorioQuestao = repositorioQuestao;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMateria;
        }



        public override void Inserir()
        {
            
            TelaCadastroQuestaoForm tela = new TelaCadastroQuestaoForm(repositorioDisciplina, repositorioMateria);
            tela.Questao = new Questao();

            tela.GravarRegistro = repositorioQuestao.Inserir;

            DialogResult resultado = tela.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                
                //List<Alternativa> alternativas = ;
                //repositorioQuestao.AdicionarAlternativas(tela.Questao, alternativas);
                //CarregarQuestoes();
            }
        }
        public override void Editar()
        {
            
        }

        public override void Excluir()
        {
           
        }



        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxQuestao();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaQuestoes == null)
                tabelaQuestoes = new TabelaQuestaoControl();

            CarregarQuestoes();

            return tabelaQuestoes;
        }

        private Materia ObtemQuestaoSelecionada()
        {
            var numero = tabelaQuestoes.ObtemNumeroMateriaSelecionada();

            return repositorioMateria.SelecionarPorNumero(numero);
        }
        private void CarregarQuestoes()
        {
            var materias = repositorioQuestao.SelecionarTodos();

            tabelaQuestoes.AtualizarRegistros(materias);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {materias.Count} materia(s)");

        }

       
    }
}
