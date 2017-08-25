using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Suncere.MultiTenancy.Dto;

namespace Suncere.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
