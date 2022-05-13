using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDonaMarina.Dominio.ModuloDisciplina;
using TestesDonaMarina.Infra.Arquivos.Compartilhado.Serializadores;

namespace TestesDonaMarina.Infra.Arquivos.Compartilhado
{
    [Serializable]
    public class DataContext
    {
        private readonly ISerializador serializador;

        public DataContext()
        {
            Disciplinas = new List<Disciplina>();


            //Materias = new List<Materia>();

            //Testes = new List<Teste>();

            //Questoes = new List<Questao>();
        }

        public DataContext(ISerializador serializador) : this()
        {
            this.serializador = serializador;

            CarregarDados();
        }

        public List<Disciplina> Disciplinas { get; set; }

       // public List<Materia> Materias { get; set; }

        //public List<Teste> Testes { get; set; }

        //public List<Quastao> Questoes { get; set; }

        public void GravarDados()
        {
            serializador.GravarDadosEmArquivo(this);
        }

        private void CarregarDados()
        {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.Disciplinas.Any())
                this.Disciplinas.AddRange(ctx.Disciplinas);

            //if (ctx.Materias.Any())
            //    this.Materias.AddRange(ctx.Materias);

            //if (ctx.Testes.Any())
            //    this.Testes.AddRange(ctx.Testes);

            //if (ctx.Questoes.Any())
            //    this.Questoes.AddRange(ctx.Questoes);
        }
    }
}
