
using TestesDonaMarina.Dominio.Compartilhado;
using TestesDonaMarina.Dominio.ModuloDisciplina;

namespace TestesDonaMarina.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public string NomeMateria { get; set; }
        public Disciplina Disciplina { get; set; }
        public Serie Serie { get; set; }

        public Materia()
        {
        }
        public Materia(int numero, Disciplina disciplina, string nome, Serie serie) : this()
        {
            Numero = numero;
            Disciplina = disciplina;
            NomeMateria = nome;
            Serie = serie;
        }
       
        public override void Atualizar(Materia registro)
        {
            this.NomeMateria = registro.NomeMateria;
            this.Disciplina = registro.Disciplina;
            this.Serie = registro.Serie;
        }
        public override string ToString()
        {
            if (this.Serie == 0)
            {
                return $"{NomeMateria}";
            }
            else
            {

                return $"{NomeMateria} - {Serie}ºsérie";
            }
        }
    }
    public enum Serie
    {
        PRIMEIRA,SEGUNDA
    }
}

