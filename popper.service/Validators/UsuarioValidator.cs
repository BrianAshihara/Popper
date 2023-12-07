using FluentValidation;
using popper.domain.Entities;

namespace popper.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
        }
    }
}
