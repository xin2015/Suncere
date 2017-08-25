using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Suncere.Roles.Dto;
using Suncere.Users.Dto;

namespace Suncere.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}