using FluentValidation.Results;
using System;
using System.Windows.Forms;
using TestesDonaMarina.Dominio.ModuloDisciplina;

namespace TestesDonaMarina.ModuloDisciplina
{
    public partial class TelaCadastroDisciplinaForm : Form
    {
        private Disciplina disciplina;

        public TelaCadastroDisciplinaForm()
        {
            InitializeComponent();
        }

        public Func<Disciplina, ValidationResult> GravarRegistro { get; set; }

        public Disciplina Disciplina
        {
            get { return disciplina; }
            set
            {
                disciplina = value;

                txtNumero.Text = disciplina.Numero.ToString();
                txtNomeDisciplina.Text = disciplina.Nome;
                //talvez precisa da série
            }
        }
        private void btnGravarDisciplina_Click(object sender, EventArgs e)
        {
            disciplina.Nome = txtNomeDisciplina.Text;


            var resultadoValidacao = GravarRegistro(disciplina);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }

        }

        //rodapés
        private void TelaCadastroDisciplinaForm_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroDisciplinaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        
    }
}
