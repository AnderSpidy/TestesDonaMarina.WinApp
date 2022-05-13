using System;
using TestesDonaMarina.Dominio.Compartilhado;

namespace TestesDonaMarina.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public Disciplina()
        {
        }

        public string Nome { get; set; }
        public override void Atualizar(Disciplina registro)
        {
        }
    }
}
