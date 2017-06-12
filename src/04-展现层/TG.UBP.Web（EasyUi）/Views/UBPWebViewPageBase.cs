using Abp.Web.Mvc.Views;

namespace TG.UBP.Web.Views
{
    public abstract class UBPWebViewPageBase : UBPWebViewPageBase<dynamic>
    {

    }

    public abstract class UBPWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected UBPWebViewPageBase()
        {
            LocalizationSourceName = UBPConsts.LocalizationSourceName;
        }
    }
}