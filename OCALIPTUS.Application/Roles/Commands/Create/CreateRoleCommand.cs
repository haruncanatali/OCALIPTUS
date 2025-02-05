using MediatR;
using Microsoft.AspNetCore.Identity;
using OCALIPTUS.Application.Common.Exceptions;
using OCALIPTUS.Application.Common.Models;
using OCALIPTUS.Domain.Identity;

namespace OCALIPTUS.Application.Roles.Commands.Create;

public class CreateRoleCommand : IRequest<BaseResponseModel<Unit>>
{
    public string Name { get; set; }
    
    public class Handler : IRequestHandler<CreateRoleCommand, BaseResponseModel<Unit>>
    {
        private readonly RoleManager<Role> _roleManager;

        public Handler(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<BaseResponseModel<Unit>> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            Role? role = await _roleManager.FindByNameAsync(request.Name);

            if (role != null)
            {
                throw new BadRequestException("This role already added.");
            }

            await _roleManager.CreateAsync(new Role
            {
                Name = request.Name
            });

            return BaseResponseModel<Unit>.Success(Unit.Value, "Role successfully added.");
        }
    }
}