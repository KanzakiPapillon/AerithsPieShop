namespace AerithsPieShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories {  get; }
            
     }
}
