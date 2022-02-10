using Abp.Application.Services;

namespace Recipe
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class RecipeAppServiceBase : ApplicationService
    {
        protected RecipeAppServiceBase()
        {
            LocalizationSourceName = RecipeConsts.LocalizationSourceName;
        }
    }
}