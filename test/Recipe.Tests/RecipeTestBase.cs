using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Recipe.EntityFrameworkCore;
using Recipe.Tests.TestDatas;

namespace Recipe.Tests
{
    public class RecipeTestBase : AbpIntegratedTestBase<RecipeTestModule>
    {
        public RecipeTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<RecipeDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<RecipeDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<RecipeDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<RecipeDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<RecipeDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<RecipeDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<RecipeDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<RecipeDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
