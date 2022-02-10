using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Recipe.EntityFrameworkCore
{
    public class RecipeDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public RecipeDbContext(DbContextOptions<RecipeDbContext> options) 
            : base(options)
        {

        }
    }
}
