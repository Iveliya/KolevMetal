using KolevMetal.Data;
using KolevMetal.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KolevMetal.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProductController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await context.Products
                .Where(p => p.IsActive)
                .Select(p => new ProductIndexViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    CategoryName = p.Category.Name,

                    ImageUrl = p.Images
                        .OrderByDescending(i => i.IsMain)
                        .ThenBy(i => i.SortOrder)
                        .Select(i => i.ImagePath)
                        .FirstOrDefault()
                })
                .ToListAsync();

            return View(products);
        }

    }
}