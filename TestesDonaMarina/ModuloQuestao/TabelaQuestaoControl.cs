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
using TestesDonaMarina.Dominio.ModuloMateria;

namespace TestesDonaMarina.ModuloQuestao
{
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "NomeMateria", HeaderText = "Matéria"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina.Nome", HeaderText = "Disciplina"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Serie", HeaderText = "Serie"},

            };

            return colunas;
        }
        public int ObtemNumeroMateriaSelecionada()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Materia> materias)
        {
            grid.Rows.Clear();

            foreach (var materia in materias)
            {
                grid.Rows.Add(materia.Numero, materia.NomeMateria, materia.Disciplina.Nome, materia.Serie);
            }
        }
    }
}
