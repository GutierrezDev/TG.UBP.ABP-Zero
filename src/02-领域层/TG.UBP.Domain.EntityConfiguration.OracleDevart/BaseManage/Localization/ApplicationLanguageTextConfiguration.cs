using Abp.Localization;
using TG.UBP.EF;

namespace TG.UBP.Domain.EntityConfiguration.OracleDevart.BaseManage.Localization
{
    public class ApplicationLanguageTextConfiguration : EntityConfigurationBase<ApplicationLanguageText, long>
    {
        public ApplicationLanguageTextConfiguration()
        {
            Property(j => j.Value)
                .HasMaxLength(4000);
        }
    }
}
