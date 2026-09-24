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

        // GET: /Product
        public async Task<IActionResult> Index()
        {
            var products = await context.Products
                .Include(p => p.Category)
                .Include(p => p.Images)
                .Select(p => new ProductIndexViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
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

        // GET: /Product/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var product = await context.Products
                .Include(p => p.Category)
                .Include(p => p.Images)
                .Where(p => p.Id == id)
                .Select(p => new ProductDetailsViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    CategoryName = p.Category.Name,

                    Images = p.Images
                        .Select(i => i.ImagePath)
                        .ToList()
                })
                .FirstOrDefaultAsync();

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}