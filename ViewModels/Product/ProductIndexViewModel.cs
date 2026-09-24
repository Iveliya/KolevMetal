namespace KolevMetal.ViewModels.Product
{
    public class ProductIndexViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public string CategoryName { get; set; } = null!;

        public string? ImageUrl { get; set; }
    }
}
