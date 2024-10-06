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
using NuGet.Protocol.Plugins;

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

        public IActionResult Edit(int? id) 
        {

            if (id == null) 
            {
               return NotFound();
            }
           var obj = _productsServices.FindById(id.Value);
            if (obj == null) 
            { 
                return NotFound();
            }
            return View(obj);   

        }
      

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Product product)
        {

            if(id != product.Id) {return BadRequest();}


            _productsServices.Update(product);
             return RedirectToAction(nameof(Index));
        
    }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Material(int id, Product product)
        {

            if (id != product.Id) { return BadRequest(); }

            var products = _productsServices.GetMaterials();
            return View(product);
         

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddMaterial(int id, RawMaterial material)
        {
            if (id == null)
            {
                return NotFound();
            }


            _productsServices.AddMaterial(id, material);
            return RedirectToAction(nameof(Index));
        }




    }
}