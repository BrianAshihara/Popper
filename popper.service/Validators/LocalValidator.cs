using FluentValidation;
using popper.domain.Entities;

namespace popper.Service.Validators
{
    public class LocalValidator : AbstractValidator<Local>
    {
        public LocalValidator()
        {
            RuleFor(c => c.Localdesc)
                .NotEmpty().WithMessage("Por favor informe a descricao do local.")
                .NotNull().WithMessage("Por favor informe a descricao do local.");
        }
    }
}
