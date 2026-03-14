namespace LargeDataAPI.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public DateOnly CreateDate { get; set; }
    }
}
