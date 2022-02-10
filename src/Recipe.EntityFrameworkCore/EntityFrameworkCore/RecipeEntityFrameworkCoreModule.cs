using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Recipe.EntityFrameworkCore
{
    [DependsOn(
        typeof(RecipeCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class RecipeEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RecipeEntityFrameworkCoreModule).GetAssembly());
        }
    }
}