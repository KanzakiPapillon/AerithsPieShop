using Microsoft.Identity.Client;

namespace AerithsPieShop.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly AerithsPieShopDbContext _aerithsPieShopDbContext;

        public CategoryRepository(AerithsPieShopDbContext aerithsPieShopDbContext)
        {
            _aerithsPieShopDbContext = aerithsPieShopDbContext;
        }   
        public IEnumerable<Category> AllCategories =>
        _aerithsPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
