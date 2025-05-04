namespace AerithsPieShop.Models
{
    public class Category
    {
        public int CateogoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Pie>? Pies { get; set; }

    }
}
