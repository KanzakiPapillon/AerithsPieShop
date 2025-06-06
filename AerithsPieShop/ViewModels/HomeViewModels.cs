using AerithsPieShop.Models;
namespace AerithsPieShop.ViewModels
{
    public class HomeViewModels
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; }
        public HomeViewModels(IEnumerable<Pie> piesOfTheWeek)
        {
            PiesOfTheWeek = piesOfTheWeek;
        }
    }
}
