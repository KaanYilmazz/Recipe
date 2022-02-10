using Abp.AspNetCore.Mvc.Controllers;

namespace Recipe.Web.Controllers
{
    public abstract class RecipeControllerBase: AbpController
    {
        protected RecipeControllerBase()
        {
            LocalizationSourceName = RecipeConsts.LocalizationSourceName;
        }
    }
}