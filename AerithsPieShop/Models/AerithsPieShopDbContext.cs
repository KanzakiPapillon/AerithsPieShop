using Microsoft.EntityFrameworkCore;

namespace AerithsPieShop.Models
{
    public class AerithsPieShopDbContext: DbContext
    {
        public AerithsPieShopDbContext(DbContextOptions<AerithsPieShopDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Pie> Pies { get; set; } 

        
    }
    
}

