using System.Collections.Generic;
using Suncere.Roles.Dto;
using Suncere.Users.Dto;

namespace Suncere.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}