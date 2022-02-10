using Abp.Modules;
using Abp.Reflection.Extensions;
using Recipe.Localization;

namespace Recipe
{
    public class RecipeCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            RecipeLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = RecipeConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RecipeCoreModule).GetAssembly());
        }
    }
}