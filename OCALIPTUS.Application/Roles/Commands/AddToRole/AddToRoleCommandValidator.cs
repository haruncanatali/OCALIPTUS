using FluentValidation;
using OCALIPTUS.Application.Common.Models;

namespace OCALIPTUS.Application.Roles.Commands.AddToRole;

public class AddToRoleCommandValidator : AbstractValidator<AddToRoleCommand>
{
    public AddToRoleCommandValidator()
    {
        RuleFor(c => c.RoleId).NotNull()
            .WithName(GlobalPropertyDisplayName.RoleId);
        RuleFor(c => c.UserId).NotNull()
            .WithName(GlobalPropertyDisplayName.UserId);
    }
}