using FluentValidation;
using OCALIPTUS.Application.Common.Models;

namespace OCALIPTUS.Application.Auth.Queries.RefreshToken;

public class RefreshTokenCommandValidator : AbstractValidator<RefreshTokenCommand>
{
    public RefreshTokenCommandValidator()
    {
        RuleFor(c => c.RefreshToken).NotEmpty()
            .WithName(GlobalPropertyDisplayName.RefreshTokenValue);
    }
}