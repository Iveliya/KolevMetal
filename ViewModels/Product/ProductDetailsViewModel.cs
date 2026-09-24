namespace KolevMetal.ViewModels.Product
{
    public class ProductDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public string CategoryName { get; set; } = null!;

        public List<string> Images { get; set; } = new();
    }
}
