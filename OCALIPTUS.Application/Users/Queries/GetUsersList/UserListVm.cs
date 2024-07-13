using OCALIPTUS.Application.Users.Queries.Dtos;

namespace OCALIPTUS.Application.Users.Queries.GetUsersList;

public class UserListVm
{
    public IList<UserDetailDto> Users { get; set; }

    public int Count { get; set; }
}