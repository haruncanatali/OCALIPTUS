using FluentValidation;
using OCALIPTUS.Application.Common.Models;

namespace OCALIPTUS.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithName(GlobalPropertyDisplayName.UpdateId);
            RuleFor(x => x.FirstName).NotEmpty().WithName(GlobalPropertyDisplayName.FirstName);
            RuleFor(x => x.Surname).NotEmpty().WithName(GlobalPropertyDisplayName.LastName);
            RuleFor(x => x.Email).EmailAddress().WithName(GlobalPropertyDisplayName.Email);
            RuleFor(c => c.Gender).NotNull().WithMessage(GlobalPropertyDisplayName.Gender);
            RuleFor(c => c.Birthdate).NotNull().WithMessage(GlobalPropertyDisplayName.Birthdate);
            RuleFor(c => c.MemberStatus).NotNull().WithMessage(GlobalPropertyDisplayName.MemberStatus);
            RuleFor(c => c.Age).NotNull().WithMessage(GlobalPropertyDisplayName.Age);
            RuleFor(c => c.Nationality).NotNull().WithMessage(GlobalPropertyDisplayName.Nationality);
            RuleFor(c => c.IdentityNumber).NotNull().WithMessage(GlobalPropertyDisplayName.IdentityNumber);
        }
    }
}
