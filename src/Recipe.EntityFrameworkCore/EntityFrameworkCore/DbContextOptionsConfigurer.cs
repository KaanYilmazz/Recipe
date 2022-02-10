using Microsoft.EntityFrameworkCore;

namespace Recipe.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<RecipeDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for RecipeDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
