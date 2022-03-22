using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductWEB.Context;
using ProductWEB.Models;
using System.Threading.Tasks;

namespace ProductWEB.Controllers
{
    public class ProductController:Controller
    {
        private readonly ApplicationDbContext context;

        public ProductController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await context.Products.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Status = true;
                product.CreateDate = System.DateTime.Now;
                await context.Products.AddAsync(product);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
    }
}
