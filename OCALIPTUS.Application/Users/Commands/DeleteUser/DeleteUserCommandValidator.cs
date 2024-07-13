using FluentValidation;
using OCALIPTUS.Application.Common.Models;

namespace OCALIPTUS.Application.Users.Commands.DeleteUser
{
    public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
    {
        public DeleteUserCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().GreaterThan(0).WithName(GlobalPropertyDisplayName.UpdateId);
        }
    }
}
