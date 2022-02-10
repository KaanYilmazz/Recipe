using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Recipe.Web.Startup;
namespace Recipe.Web.Tests
{
    [DependsOn(
        typeof(RecipeWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class RecipeWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RecipeWebTestModule).GetAssembly());
        }
    }
}