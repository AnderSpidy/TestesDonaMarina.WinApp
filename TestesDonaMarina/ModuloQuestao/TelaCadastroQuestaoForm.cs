
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private Questao questao;
        public TelaCadastroQuestaoForm(List<Disciplina> disciplinas, List<Materia> materias)
        {
            InitializeComponent();
            CarregarDisciplinas(disciplinas);
            CarregarMateria(materias);
            
        }
        //public Func<Questao, ValidationResult> GravarRegistro { get; set; }
        //não entendo o porque o delegate hora fuinciona , hora nao
        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cmbDisciplina.Items.Clear();
            foreach (var item in disciplinas)
            {
                cmbDisciplina.Items.Add(item);
            }
        }
        private void CarregarMateria(List<Materia> materias)
        {
            //ver uma forma de filtrar apenas o agrupamento da disciplina selecionada
            cmbMateria.Items.Clear();
            foreach (var item in materias)
            {
                cmbMateria.Items.Add(item);
            }
        }

        

        public List<AlternativasQuestao> AlternativasAdicionadas
        {
            get
            {
                return listAlternativas.Items.Cast<AlternativasQuestao>().ToList();
            }
        }
        
        
        public Questao Questao
        {
            get { return questao; }
            set
            {
                questao = value;
                txtEnunciado.Text = questao.Enunciado.ToString(); 
            }
        }
        private void TelaCadastroQuestaoForm_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }


        private void TelaCadastroQuestaoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            List<string> alternativas = AlternativasAdicionadas.Select(x => x.Descricao).ToList();
            if (alternativas.Count == 0 || alternativas.Contains(txtAlternativa.Text) == false)
            {
                AlternativasQuestao alternativaQuestao = new AlternativasQuestao();

                alternativaQuestao.Descricao = txtAlternativa.Text;

                listAlternativas.Items.Add(alternativaQuestao);
            }

        }

        private void btnGravarDisciplina_Click(object sender, EventArgs e)
        {

        }
    }
}
