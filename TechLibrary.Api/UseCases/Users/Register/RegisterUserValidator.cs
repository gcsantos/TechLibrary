using FluentValidation;
using TechLibrary.Communication.Request;

namespace TechLibrary.Api.UseCases.Users.Register;

public class RegisterUserValidator : AbstractValidator<RequestUserJson>
{
    public RegisterUserValidator()
    {
        RuleFor(request => request.Name).NotEmpty().WithMessage("Nome obrigatorio!");
        RuleFor(request => request.Email).EmailAddress().WithMessage("Email invalido!");
        RuleFor(request => request.Password).NotEmpty().WithMessage("Senha obrigatorio!");
        When(request => string.IsNullOrEmpty(request.Password) == false, () =>
        {
            RuleFor(request => request.Password.Length).GreaterThanOrEqualTo(6).WithMessage("Senha não pode ser vazio e ser maior que 6 caractere!");
        });
    }
}
