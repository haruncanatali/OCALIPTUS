using MediatR;
using OCALIPTUS.Application.Common.Models;
using OCALIPTUS.Application.Roles.Queries.Dtos;

namespace OCALIPTUS.Application.Roles.Queries.GetRoles;

public class GetRolesQuery : IRequest<BaseResponseModel<List<RoleDto>>>
{
    public string? Name { get; set; }
}