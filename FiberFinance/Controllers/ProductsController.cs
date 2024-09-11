using FiberFinance.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace FiberFinance.Controllers
{
    public class ProductsController : Controller
    {

        private readonly FiberFinanceContext _context;

        public ProductsController(FiberFinanceContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var products = _context.Product.ToList(); 
            return View(products);

        }
    }
}
