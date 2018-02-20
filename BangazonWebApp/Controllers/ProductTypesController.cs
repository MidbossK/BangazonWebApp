using Bangazon.Models;
using Bangazon.Models.ProductViewModels;
using BangazonWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonWebApp.Controllers
{
    public class ProductTypesController : Controller
    {
        private ApplicationDbContext _context;

        public ProductTypesController(ApplicationDbContext ctx)
        {
            _context = ctx;
        }
        public async Task<IActionResult> Types()
        {
            var model = new ProductTypeViewModel();

            // Build list of Product instances for display in view
            // LINQ is awesome
            model.GroupedProducts = await (
                from t in _context.ProductTypes
                join p in _context.Products
                on t.ProductTypeId equals p.ProductTypeId
                group new { t, p } by new { t.ProductTypeId, t.Category } into grouped
                select new GroupedProducts
                {
                    TypeId = grouped.Key.ProductTypeId,
                    TypeName = grouped.Key.Category,
                    ProductCount = grouped.Select(x => x.p.ProductId).Count(),
                    Products = grouped.Select(x => x.p).Take(3)
                }).ToListAsync();

            return View(model);
        }
    }
} 