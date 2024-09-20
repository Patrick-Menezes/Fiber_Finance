using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FiberFinance.Data;
using FiberFinance.Models;
using FiberFinance.services;

namespace FiberFinance.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ProductsServices _productsServices;

        public ProductsController(ProductsServices productsServices)
        {
            _productsServices = productsServices;
        }

        // GET: Products
        public IActionResult Index()
        {
            var list = _productsServices.GetAll();

            return View(list);
        }


        public IActionResult Create()
        {
             return View();
        
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            _productsServices.Insert(product);
            return RedirectToAction(nameof(Index));
        }




    }
}