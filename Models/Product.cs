namespace Rira_Backend_task.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Categories Category { get; set; }
        public Decimal Price { get; set; }
    }
}
