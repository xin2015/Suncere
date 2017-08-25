using Abp.Web.Mvc.Views;

namespace Suncere.Web.Views
{
    public abstract class SuncereWebViewPageBase : SuncereWebViewPageBase<dynamic>
    {

    }

    public abstract class SuncereWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SuncereWebViewPageBase()
        {
            LocalizationSourceName = SuncereConsts.LocalizationSourceName;
        }
    }
}