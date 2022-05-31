using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TestesDonaMarina.Dominio.ModuloDisciplina;
using TestesDonaMarina.Dominio.ModuloMateria;
using TestesDonaMarina.Dominio.ModuloQuestao;
using TestesDonaMarina.Dominio.ModuloTeste;

namespace TestesDonaMarina.ModulosTeste
{
    public partial class TelaCriacaoTesteForm : Form
    {
        IRepositorioDisciplina repositorioDisciplina;
        IRepositorioMateria repositorioMateria;
        IRepositorioQuestao repositorioQuestao;
        private Teste teste;
        public TelaCriacaoTesteForm(IRepositorioDisciplina repositorioDisciplina, IRepositorioMateria repositorioMateria, IRepositorioQuestao repositorioQuestao)
        {
            InitializeComponent();
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMateria;
            this.repositorioQuestao = repositorioQuestao;
            CarregarDisciplinas();
        }



        public Teste Teste
        {
            get { return teste; }
            set
            {
                teste = value;
                txtTituloTeste.Text = teste.Titulo;
                cmbDisciplina.SelectedItem = teste.Disciplina;
                cmbMateria.SelectedItem = teste.Materia;
                listBoxQuestoes.Items.AddRange(teste.Questoes.ToArray());
            }

        }

        public Func<Teste, ValidationResult> GravarRegistro { get; set; }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            int qtdQuestoes = listBoxQuestoes.Items.Count;
            if (qtdQuestoes < 5)
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente criar um teste com menos de 5 questões?",
              "Geração de Testes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    teste.Titulo = txtTituloTeste.Text;
                    teste.Disciplina = (Disciplina)cmbDisciplina.SelectedItem;
                    teste.Questoes = QuestoesSorteadas;

                    if (cmbMateria.SelectedItem == null)
                    {
                        Materia novaMateria = new Materia();
                        novaMateria.NomeMateria = "Todas";
                        teste.Materia = novaMateria;
                    }
                    else
                    {
                        teste.Materia = (Materia)cmbMateria.SelectedItem;
                    }

                    var resultadoValidacao = GravarRegistro(teste);
                    if (resultadoValidacao.IsValid == false)
                    {
                        string erro = resultadoValidacao.Errors[0].ErrorMessage;

                        TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                        DialogResult = DialogResult.None;
                    }
                }
            }

        }


        public List<Questao> QuestoesSorteadas
        {
            get
            {
                return listBoxQuestoes.Items.Cast<Questao>().ToList();
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

        private void comboBoxDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxProvaRecuperacao.Enabled = true;
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

        private void btnSortearQuestoes_Click(object sender, EventArgs e)
        {
            btnGravar.Enabled = true;
            listBoxQuestoes.Items.Clear();

            if (checkBoxProvaRecuperacao.Checked)
            {
                int qtdQuestoes = (int)numQuestoes.Value;
                Disciplina disciplinaSelecionada = (Disciplina)cmbDisciplina.SelectedItem;

                List<Questao> questoesSorteadasDisciplina = repositorioQuestao.SortearQuestoesRecuperacao(disciplinaSelecionada, qtdQuestoes);
                foreach (Questao q in questoesSorteadasDisciplina)
                {
                    listBoxQuestoes.Items.Add(q);
                }
            }
            else
            {

                int qtdQuestoes = (int)numQuestoes.Value;
                Materia materiaSelecionada = (Materia)cmbMateria.SelectedItem;

                List<Questao> questoesSorteadas = repositorioQuestao.Sortear(materiaSelecionada, qtdQuestoes);
                foreach (Questao q in questoesSorteadas)
                {
                    listBoxQuestoes.Items.Add(q);
                }
            }
        }

        private void comboBoxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            numQuestoes.Enabled = true;
            numQuestoes.Minimum = 1;
            numQuestoes.Maximum = ObtemQuantidadeMaxima();
            if (numQuestoes.Value == 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Não existem questões cadastradas para a matéria selecionada!");
                btnSortearQuestoes.Enabled = false;

            }

        }

        private decimal ObtemQuantidadeMaxima()
        {
            Materia m = (Materia)cmbMateria.SelectedItem;
            List<Questao> questoesMateriaSelecionada = repositorioQuestao.SelecionarTodos().Where(x => x.Materia.NomeMateria.Equals(m.NomeMateria)).ToList();
            return questoesMateriaSelecionada.Count;
        }

        private void numQuestoes_ValueChanged(object sender, EventArgs e)
        {
            btnSortearQuestoes.Enabled = true;
            TelaPrincipalForm.Instancia.AtualizarRodape("");

        }

        private void checkBoxProvaRecuperacao_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxProvaRecuperacao.Checked)
            {
                cmbMateria.SelectedIndex = -1;
                cmbMateria.Enabled = false;
                numQuestoes.Enabled = true;
                numQuestoes.Minimum = 1;
                numQuestoes.Maximum = ObtemQuantidadeMaximaRecuperacao();
                if (numQuestoes.Value == 0)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("Não existem questões cadastradas para a disciplina selecionada!");
                    btnSortearQuestoes.Enabled = false;
                }
            }
            else
            {
                cmbMateria.SelectedIndex = -1;
                cmbMateria.Enabled = true;
                numQuestoes.ResetText();
                listBoxQuestoes.Items.Clear();
            }


        }

        private decimal ObtemQuantidadeMaximaRecuperacao()
        {
            Disciplina d = (Disciplina)cmbDisciplina.SelectedItem;
            List<Questao> questoesDisciplinaSelecionada = repositorioQuestao.SelecionarTodos().Where(x => x.Disciplina.Equals(d)).ToList();
            return questoesDisciplinaSelecionada.Count;
        }

        #region rodapé
        private void TelaCadastroTeste_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");

        }

        private void TelaCadastroTeste_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");

        }
        #endregion
    }
}
