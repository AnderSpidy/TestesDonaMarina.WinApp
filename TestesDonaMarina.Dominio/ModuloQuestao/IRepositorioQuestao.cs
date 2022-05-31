
using System.Collections.Generic;
using TestesDonaMarina.Dominio.Compartilhado;
using TestesDonaMarina.Dominio.ModuloDisciplina;
using TestesDonaMarina.Dominio.ModuloMateria;

namespace TestesDonaMarina.Dominio.ModuloQuestao
{
    public interface IRepositorioQuestao : IRepositorio<Questao>
    {
        void AdicionarAlternativas(Questao q, List<Alternativa> a);
        List<Questao> Sortear(Materia materia, int qtd);
        List<Questao> SortearQuestoesRecuperacao(Disciplina disciplina, int qtd);
    }
}
