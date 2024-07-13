using MediatR;
using OCALIPTUS.Application.Users.Queries.Dtos;

namespace OCALIPTUS.Application.Users.Queries.GetUserDetail
{
    public class UserDetailQuery : IRequest<UserDetailDto>
    {
        public long Id { get; set; }
    }
}