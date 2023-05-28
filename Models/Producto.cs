namespace SupermarketWEB.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int Amount { get; set; }
        public string? Description { get; set; }
        public ICollection<Producto>? Products { get; set; } = default!;
    }
}
