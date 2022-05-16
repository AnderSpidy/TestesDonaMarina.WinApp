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
        private Materia materia;

        public TelaCadastroMateriaForm(List<Disciplina> disciplinas)
        {
            InitializeComponent();
            CarregarDisciplina(disciplinas);
        }
    
        private void CarregarDisciplina(List<Disciplina> disciplinas)
        {
            cmbDisciplina.Items.Clear();
            foreach(var item in disciplinas)
            {
                cmbDisciplina.Items.Add(item);
            }
        }

        public Func<Materia, ValidationResult> GravarRegistro { get; set; }

        public Materia Materia
        {
            get { return materia; }
            set
            {
                materia = value;
                //txtNomeMateria.Text = materia.NomeMateria.ToString();
                cmbDisciplina.SelectedItem = materia.Disciplina != null;
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
    }

}
