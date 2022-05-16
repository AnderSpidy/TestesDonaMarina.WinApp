using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using TestesDonaMarina.Dominio.ModuloMateria;
using TestesDonaMarina.Infra.Arquivos.Compartilhado;

namespace TestesDonaMarina.Infra.Arquivos.ModuloMateria
{
    public class RepositorioMateriaEmArquivo : RepositorioEmArquivoBase<Materia>,IRepositorioMateria
    {
        public RepositorioMateriaEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Disciplinas.Count > 0)
                contador = dataContext.Disciplinas.Max(x => x.Numero);
        }

        public override List<Materia> ObterRegistros()
        {
            return dataContext.Materias;
        }
        public override AbstractValidator<Materia> ObterValidador()
        {
            return new ValidadorMateria();
        }

    }
}
