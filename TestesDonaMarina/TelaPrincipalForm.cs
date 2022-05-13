﻿using System;
using System.Collections.Generic;
using TestesDonaMarina.Infra.Arquivos.ModuloDisciplina;
using System.Windows.Forms;
using TestesDonaMarina.Compartilhado;
using TestesDonaMarina.Infra.Arquivos.Compartilhado;
using TestesDonaMarina.ModuloDisciplina;
using TestesDonaMarina.ModuloMateria;
using TestesDonaMarina.ModuloQuestao;
using TestesDonaMarina.ModulosTeste;

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
            ListagemMateriaControl listagem = new ListagemMateriaControl();
            panelDeRegistros.Controls.Clear();
            panelDeRegistros.Controls.Add(listagem);
        }

        private void questoesMenuItem_Click(object sender, EventArgs e)
        {
            ListagemQuestaoControl listagem = new ListagemQuestaoControl();
            panelDeRegistros.Controls.Clear();
            panelDeRegistros.Controls.Add(listagem);
        }

        private void testesMenuItem_Click(object sender, EventArgs e)
        {
            ListagemTesteControl listagem = new ListagemTesteControl();
            panelDeRegistros.Controls.Clear();
            panelDeRegistros.Controls.Add(listagem);
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
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
            var repositorioDisciplina = new RepositorioDisciplinaEmArquivo(contextoDados);
            //var repositorioContato = new RepositorioContatoEmArquivo(contextoDados);
            //var repositorioCompromisso = new RepositorioCompromissoEmArquivo(contextoDados);
            //var repositorioDespesa = new RepositorioDespesaEmArquivo(contextoDados);

            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("Disciplinas", new ControladorDisciplina(repositorioDisciplina));
            //controladores.Add("Contatos", new ControladorContato(repositorioContato));
            //controladores.Add("Compromissos", new ControladorCompromisso(repositorioCompromisso, repositorioContato));
            //controladores.Add("Despesas", new ControladorDespesa(repositorioDespesa));
        }

   
    }
}