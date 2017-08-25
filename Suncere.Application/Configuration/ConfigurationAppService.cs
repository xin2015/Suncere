using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Suncere.Configuration.Dto;

namespace Suncere.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SuncereAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
