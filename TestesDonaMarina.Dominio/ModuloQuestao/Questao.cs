using System;
using System.Collections.Generic;
using TestesDonaMarina.Dominio.Compartilhado;
using TestesDonaMarina.Dominio.ModuloDisciplina;
using TestesDonaMarina.Dominio.ModuloMateria;

namespace TestesDonaMarina.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        private List<AlternativasQuestao> alternativas = new List<AlternativasQuestao>();
        public Questao()
        {
        }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public string Enunciado {get;set;}
        public List<AlternativasQuestao> Alternativas { get { return alternativas; } }
        
        public void AdicionarAlternativa(AlternativasQuestao alternativa)
        {
            if (Alternativas.Exists(x => x.Equals(alternativa)) == false)
                alternativas.Add(alternativa);
        }
        public override void Atualizar(Questao registro)
        {
            this.Enunciado = registro.Enunciado;
        }
    }
}
