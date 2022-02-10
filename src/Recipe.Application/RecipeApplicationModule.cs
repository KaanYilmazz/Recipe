using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Recipe
{
    [DependsOn(
        typeof(RecipeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RecipeApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RecipeApplicationModule).GetAssembly());
        }
    }
}