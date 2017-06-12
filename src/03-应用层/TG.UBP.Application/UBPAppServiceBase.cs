using Abp.Application.Services;

namespace TG.UBP
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class UBPAppServiceBase : ApplicationService
    {
        protected UBPAppServiceBase()
        {
            LocalizationSourceName = UBPConsts.LocalizationSourceName;
        }
    }
}