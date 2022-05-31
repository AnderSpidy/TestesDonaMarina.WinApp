using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestesDonaMarina.Compartilhado;
using TestesDonaMarina.Dominio.ModuloTeste;

namespace TestesDonaMarina.ModulosTeste
{
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();           
            grid.Columns.AddRange(ObterColunas());

        }

        private DataGridViewColumn[] ObterColunas()
        {

            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "Número"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Título"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Materia"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Questoes.Count", HeaderText = "Qtd. Questões"},
                new DataGridViewTextBoxColumn { DataPropertyName = "DataCriacao", HeaderText = "Data de Criação"}

            };

            return colunas;
        }


        public void AtualizarRegistros(List<Teste> testes)
        {
            grid.Rows.Clear();
            foreach (Teste t in testes)
            {
                grid.Rows.Add(t.Numero, t.Titulo, t.Disciplina, t.Materia, t.Questoes.Count, t.dataCriacao);
            }
        }

        public int ObtemNumeroTesteSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }
    }
}
