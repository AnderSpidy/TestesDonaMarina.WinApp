using FluentValidation;


namespace TestesDonaMarina.Dominio.ModuloMateria
{
    public class ValidadorMateria : AbstractValidator <Materia>
    {
        public ValidadorMateria()
        {
            RuleFor(x => x.NomeMateria).NotNull().NotEmpty();
            RuleFor(x => x.Disciplina).NotNull().NotEmpty();
            
        }
    }
}
