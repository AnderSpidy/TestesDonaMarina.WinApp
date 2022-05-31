using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestesDonaMarina.Dominio.ModuloDisciplina;
using TestesDonaMarina.Dominio.ModuloMateria;

namespace TestesDonaMarina.ModuloMateria
{
    public partial class TelaCadastroMateriaForm : Form
    {
        IRepositorioDisciplina repositorioDisciplina;

        private Materia materia;

        public TelaCadastroMateriaForm(IRepositorioDisciplina repositorioDisciplina)
        {
            InitializeComponent();

            this.repositorioDisciplina = repositorioDisciplina;
            CarregarDisciplina();
        }
        public Func<Materia, ValidationResult> GravarRegistro { get; set; }

        public Materia Materia
        {
            get
            {
                return materia;
            }
            set
            {
                materia = value;
                txtNomeMateria.Text = materia.NomeMateria;
                cmbDisciplina.SelectedItem = materia.Disciplina;
                GravarSerie();

            }
        }

        private void GravarSerie()
        {
            if (Materia.Serie == Serie.PRIMEIRA)
            {
                rdbPrimeira.Checked = true;
            }
            else if (Materia.Serie == Serie.SEGUNDA)
            {
                rdbSegunda.Checked = true;
            }
        }

        private void CarregarDisciplina()
        {
            
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            foreach (Disciplina item in disciplinas)
            {
                cmbDisciplina.Items.Add(item);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            materia.NomeMateria = txtNomeMateria.Text;
            materia.Disciplina = (Disciplina)cmbDisciplina.SelectedItem;
            if (rdbPrimeira.Checked)
            {
                materia.Serie = Serie.PRIMEIRA;
            }
            else
            {
                materia.Serie = Serie.SEGUNDA;
            }
            var resultadoValidacao = GravarRegistro(materia);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
           
        }

        private void TelaCadastroCompromissosForm_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }


        private void TelaCadastroMateriaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }
    }

}
