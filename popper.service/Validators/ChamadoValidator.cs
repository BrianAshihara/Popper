using FluentValidation;
using popper.domain.Entities;

namespace popper.Service.Validators
{
    public class ChamadoValidator : AbstractValidator<Chamado>
    {
        public ChamadoValidator()
        {
            RuleFor(c => c.Status)
                .NotEmpty().WithMessage("Por favor informe o status do problema.")
                .NotNull().WithMessage("Por favor informe do problema.");

            RuleFor(c => c.Desc)
                 .NotEmpty().WithMessage("Por favor informe a descricao do problema.")
                .NotNull().WithMessage("Por favor informe a descricao do problema.");
        }
    }
}

