using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestesDonaMarina.Compartilhado;
using TestesDonaMarina.Dominio.ModuloDisciplina;
using TestesDonaMarina.Dominio.ModuloMateria;

namespace TestesDonaMarina.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        IRepositorioMateria repositorioMateria;
        IRepositorioDisciplina repositorioDisciplina;
       
        TabelaMateriaControl tabelaMateria;

        public ControladorMateria(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMateria;
        }

        public override void Inserir()
        {
            TelaCadastroMateriaForm tela = new TelaCadastroMateriaForm(repositorioDisciplina);
            tela.Materia = new Materia();

            tela.GravarRegistro = repositorioMateria.Inserir;

            DialogResult resultado = tela.ShowDialog();
            if (resultado == DialogResult.OK)
                CarregarMaterias();
        }
        public override void Editar()
        {
            Materia materiaDisciplina = ObtemMateriaSelecionada();

            if (materiaDisciplina == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro",
                "Edição de Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //var disciplinas = repositorioDisciplina.SelecionarTodos();

            TelaCadastroMateriaForm tela = new TelaCadastroMateriaForm(repositorioDisciplina);

            tela.Materia = materiaDisciplina;

            tela.GravarRegistro = repositorioMateria.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioMateria.Editar(tela.Materia);
                CarregarMaterias();
            }
        }

        public override void Excluir()
        {
            Materia materiaSelecionada = ObtemMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro",
                "Exclusão de Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a disciplina?",
                "Exclusão de Disciplina", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioMateria.Excluir(materiaSelecionada);
                CarregarMaterias();
            }
        }

        private Materia ObtemMateriaSelecionada()
        {
            var numero = tabelaMateria.ObtemNumeroMateriaSelecionada();

            return repositorioMateria.SelecionarPorNumero(numero);
        }
        private void CarregarMaterias()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(materias);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {materias.Count} materia(s)");

        }
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxMateria();
        }

        public override UserControl ObtemListagem()
        {
            tabelaMateria = new TabelaMateriaControl();


            CarregarMaterias();

            return tabelaMateria;
        }
    }
}
