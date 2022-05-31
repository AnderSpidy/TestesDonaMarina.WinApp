using System;
using System.Collections.Generic;
using TestesDonaMarina.Infra.Arquivos.ModuloDisciplina;
using System.Windows.Forms;
using TestesDonaMarina.Compartilhado;
using TestesDonaMarina.Infra.Arquivos.Compartilhado;
using TestesDonaMarina.ModuloDisciplina;
using TestesDonaMarina.ModuloMateria;
using TestesDonaMarina.ModuloQuestao;
using TestesDonaMarina.ModulosTeste;
using TestesDonaMarina.Infra.Arquivos.ModuloMateria;
using TestesDonaMarina.Infra.Arquivos.ModuloQuestao;
using testesDaMariana.Infra.BancoDeDados.ModuloDisciplina;
using TestesDonaMarina.Infra.Arquivos.ModuloTeste;
using testesDaMariana.Infra.BancoDeDados.ModuloMateria;
using testesDaMariana.Infra.BancoDeDados.ModuloQuestao;
using testesDaMariana.Infra.BancoDeDados.ModuloTeste;

namespace TestesDonaMarina
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        private DataContext contextoDados;
        public TelaPrincipalForm(DataContext contextoDados)
        {
            InitializeComponent();

            Instancia = this;

            labelRodape.Text = string.Empty;
            labelTipoCadastro.Text = string.Empty;

            this.contextoDados = contextoDados;

            InicializarControladores();

        }
        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }
        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }
        private void disciplinasMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void materiasMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void questoesMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void testesMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btdPdf_Click(object sender, EventArgs e)
        {

        }
        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.Enabled = configuracao.InserirHabilitado;
            btnEditar.Enabled = configuracao.EditarHabilitado;
            btnExcluir.Enabled = configuracao.ExcluirHabilitado;
            
        }

        private void ConfigurarTooltips(ConfiguracaoToolboxBase configuracao)
        {
            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;
           
        }

        private void ConfigurarTelaPrincipal(ToolStripMenuItem opcaoSelecionada)
        {
            var tipo = opcaoSelecionada.Text;

            controlador = controladores[tipo];

            ConfigurarToolbox();

            ConfigurarListagem();
        }

        private void ConfigurarToolbox()
        {
            ConfiguracaoToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                toolStrip1.Enabled = true;

                labelTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            panelDeRegistros.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelDeRegistros.Controls.Add(listagemControl);
        }

        private void InicializarControladores()
        {
            var repositorioDisciplina = new RepositorioDisciplinaEmBancoDeDados();
            var repositorioMateria = new RepositorioMateriaEmBancoDeDados();
            var repositorioQuestao = new RepositorioQuestaoEmBancoDeDados();
            var repositorioTeste = new RepositorioTesteEmBancoDeDados();

            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("Disciplinas", new ControladorDisciplina(repositorioDisciplina));
            controladores.Add("Matérias", new ControladorMateria(repositorioMateria, repositorioDisciplina));
            controladores.Add("Questões", new ControladorQuestao(repositorioQuestao,repositorioMateria,repositorioDisciplina,repositorioTeste));
            controladores.Add("Testes", new ControladorTeste(repositorioTeste, repositorioDisciplina, repositorioMateria, repositorioQuestao));
        }

       
    }
}
