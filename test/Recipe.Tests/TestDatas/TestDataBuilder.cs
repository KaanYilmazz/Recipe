using Recipe.EntityFrameworkCore;

namespace Recipe.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly RecipeDbContext _context;

        public TestDataBuilder(RecipeDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}