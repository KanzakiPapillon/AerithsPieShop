using Microsoft.EntityFrameworkCore;

namespace AerithsPieShop.Models
{
    public class PieRepository: IPieRepository
    {
        private readonly AerithsPieShopDbContext _aerithsPieShopDbContext;
        public PieRepository(AerithsPieShopDbContext aerithsPieShopDbContext)
        {
            _aerithsPieShopDbContext = aerithsPieShopDbContext;
        }
        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _aerithsPieShopDbContext.Pies.Include(c => c.Category);
            }
        }
        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _aerithsPieShopDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }
        public Pie? GetPieById(int pieId)
        {
            return _aerithsPieShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
