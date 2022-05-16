using FluentValidation;


namespace TestesDonaMarina.Dominio.ModuloQuestao
{
    public class ValidadorQuestao : AbstractValidator <Questao>
    {
        public ValidadorQuestao()
        {
            RuleFor(x => x.Enunciado).NotNull().NotEmpty();
        }
    }
}
