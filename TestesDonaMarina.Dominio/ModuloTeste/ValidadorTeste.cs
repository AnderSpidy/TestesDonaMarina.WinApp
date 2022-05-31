using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDonaMarina.Dominio.ModuloTeste
{
    public class ValidadorTeste : AbstractValidator<Teste>
    {
        public ValidadorTeste()
        {
            RuleFor(x => x.Titulo)
                  .NotNull().NotEmpty().MinimumLength(3);

            RuleFor(x => x.Disciplina)
             .NotNull().NotEmpty();

            RuleFor(x => x.Questoes)
            .NotNull().NotEmpty();

        }
    }
}
