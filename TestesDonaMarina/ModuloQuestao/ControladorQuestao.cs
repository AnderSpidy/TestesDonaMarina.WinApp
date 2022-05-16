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
            var disciplinas = repositorioDisciplina.SelecionarTodos();
            var materias = repositorioMateria.SelecionarTodos();

            TelaCadastroQuestaoForm tela = new TelaCadastroQuestaoForm(disciplinas,materias);
            
            tela.Questao = new Questao();
            // o inserir, no esta aceitando o  FluentValidation.Results;
            //tela.GravarRegistro = repositorioQuestao.Inserir;
            

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarQuestoes();
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
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaQuestoes.AtualizarRegistros(materias);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {materias.Count} materia(s)");

        }

       
    }
}
