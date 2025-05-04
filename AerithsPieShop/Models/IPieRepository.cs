namespace AerithsPieShop.Models
{
    public class IPieRepository
    {
    IEnumerable<Pie> AllPies { get; }
    IEnumerable<Pie> PiesOfTheWeek { get; }
    Pie GetPieById(int pieId);
    }
}
