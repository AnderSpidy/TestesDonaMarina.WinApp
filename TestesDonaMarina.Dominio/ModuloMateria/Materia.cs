
using TestesDonaMarina.Dominio.Compartilhado;
using TestesDonaMarina.Dominio.ModuloDisciplina;

namespace TestesDonaMarina.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public Materia()
        {
        }
        public string NomeMateria { get; set; }
        public Disciplina Disciplina { get; set; }
        public Serie Serie { get; set; }
        public override void Atualizar(Materia registro)
        {
        }
    }
    public enum Serie
    {
        PRIMEIRA,SEGUNDA
    }
}

