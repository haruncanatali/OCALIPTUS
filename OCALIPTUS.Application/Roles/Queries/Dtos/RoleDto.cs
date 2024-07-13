using AutoMapper;
using OCALIPTUS.Application.Common.Mappings;
using OCALIPTUS.Domain.Identity;

namespace OCALIPTUS.Application.Roles.Queries.Dtos;

public class RoleDto : IMapFrom<Role>
{
    public long Id { get; set; }
    public string Name { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Role, RoleDto>();
    }
}