using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Recipe.Configuration;
using Recipe.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace Recipe.Web.Startup
{
    [DependsOn(
        typeof(RecipeApplicationModule), 
        typeof(RecipeEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class RecipeWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public RecipeWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(RecipeConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<RecipeNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(RecipeApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RecipeWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(RecipeWebModule).Assembly);
        }
    }
}
