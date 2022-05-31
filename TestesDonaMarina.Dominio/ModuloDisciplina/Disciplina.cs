using System;
using TestesDonaMarina.Dominio.Compartilhado;

namespace TestesDonaMarina.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public Disciplina()
        {
        }
        public Disciplina(int n, string nome) : this()
        {
            Numero = n;
            Nome = nome;
        }

        public string Nome { get; set; }
        public override void Atualizar(Disciplina registro)
        {
            this.Nome = registro.Nome;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
