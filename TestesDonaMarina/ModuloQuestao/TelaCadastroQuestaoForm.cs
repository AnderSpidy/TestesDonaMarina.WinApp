
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TestesDonaMarina.Dominio.ModuloDisciplina;
using TestesDonaMarina.Dominio.ModuloMateria;
using TestesDonaMarina.Dominio.ModuloQuestao;
using FluentValidation.Results;
namespace TestesDonaMarina.ModuloQuestao
{
    public partial class TelaCadastroQuestaoForm : Form
    {
        IRepositorioDisciplina repositorioDisciplina;
        IRepositorioMateria repositorioMateria;
        private Questao questao;

        public TelaCadastroQuestaoForm(IRepositorioDisciplina repositorioDisciplina, IRepositorioMateria repositorioMateria)
        {
            InitializeComponent();
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMateria;
            CarregarDisciplinas();
            cmbLetraAlternativa.SelectedIndex = 0;
        }
        public Func<Questao, ValidationResult> GravarRegistro { get; set; }

        public Questao Questao
        {
            get
            {
                return questao;
            }
            set
            {

                questao = value;
                txtEnunciado.Text = questao.Enunciado;
                cmbDisciplina.SelectedItem = questao.Disciplina;
                cmbMateria.SelectedItem = questao.Materia;
                cmbAlternativaCorreta.SelectedItem = questao.Resposta;
                listAlternativas.Items.AddRange(questao.Alternativas.ToArray());
            }
        }

        public List<Alternativa> AlternativasAdicionadas
        {
            get
            {
                return listAlternativas.Items.Cast<Alternativa>().OrderBy(x => x.Letra)
                    .ToList();

            }
            set
            {

            }
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (AlternativasAdicionadas.Count >= 5)
            {
                questao.Disciplina = (Disciplina)cmbDisciplina.SelectedItem;
                questao.Materia = (Materia)cmbMateria.SelectedItem;
                questao.Enunciado = txtEnunciado.Text.ToString();
                questao.Resposta = (string)cmbAlternativaCorreta.SelectedItem;

                var resultadoValidacao = GravarRegistro(questao);
                if (resultadoValidacao.IsValid == false)
                {
                    string erro = resultadoValidacao.Errors[0].ErrorMessage;

                    TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("Adicione 5 alternativas à questão",
                "Cadastro de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                DialogResult = DialogResult.None;

                return;
            }

        }

        private void btnAddAlternativa_Click(object sender, EventArgs e)
        {
            listAlternativas.Sorted = true;

            List<string> letras = AlternativasAdicionadas.Select(x => x.Letra).ToList();

            List<string> descricoes = AlternativasAdicionadas.Select(x => x.Descricao).ToList();

            if (descricoes.Count == 0 || descricoes.Contains(txtAlternativa.Text) == false)
            {
                if (letras.Contains(cmbLetraAlternativa.Text) == false)
                {
                    string letra = (string)cmbLetraAlternativa.SelectedItem;
                    string descricao = txtAlternativa.Text;


                    Alternativa novaAlternativa = new Alternativa(letra, descricao, questao);
                    listAlternativas.Items.Add(novaAlternativa);
                    txtAlternativa.Clear();
                    if (cmbLetraAlternativa.SelectedIndex <= 3)
                    {
                        cmbLetraAlternativa.SelectedIndex = cmbLetraAlternativa.SelectedIndex + 1;
                    }

                }

            }

        }

        private void btnExcluirAlternativa_Click(object sender, EventArgs e)
        {

            Alternativa alternativaSelecionada = (Alternativa)listAlternativas.SelectedItem;


            if (alternativaSelecionada == null)
            {
                MessageBox.Show("Selecione uma alternativa primeiro",
                "Exclusão de Alternativas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a alternativa?",
                "Exclusão de Alternativas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                listAlternativas.Items.Remove(alternativaSelecionada);
                questao.Alternativas.Remove(alternativaSelecionada);
            }

        }

        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            foreach (Disciplina d in disciplinas)
            {
                cmbDisciplina.Items.Add(d);
            }
        }

        private void comboBoxDisciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMateria.Items.Clear();

            List<Materia> materias = repositorioMateria.SelecionarTodos();
            foreach (Materia m in materias)
            {
                if (m.Disciplina.Nome == ((Disciplina)cmbDisciplina.SelectedItem).Nome)
                {
                    cmbMateria.Items.Add(m);

                }
            }

        }

        #region rodapé
        private void TelaCadastroQuestao_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");

        }

        private void TelaCadastroQuestao_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");

        }
        #endregion

        private void comboBoxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
