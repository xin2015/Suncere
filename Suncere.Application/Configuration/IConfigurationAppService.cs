using System.Threading.Tasks;
using Abp.Application.Services;
using Suncere.Configuration.Dto;

namespace Suncere.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}