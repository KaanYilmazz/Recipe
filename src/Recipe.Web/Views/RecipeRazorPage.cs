using Abp.AspNetCore.Mvc.Views;

namespace Recipe.Web.Views
{
    public abstract class RecipeRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected RecipeRazorPage()
        {
            LocalizationSourceName = RecipeConsts.LocalizationSourceName;
        }
    }
}
