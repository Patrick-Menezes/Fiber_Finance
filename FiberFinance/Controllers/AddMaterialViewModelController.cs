using FiberFinance.Data;
using FiberFinance.Models;
using FiberFinance.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiberFinance.Controllers
{
    public class AddMaterialViewModelController : Controller
    {
      private readonly ProductsServices _productServices;
        private readonly FiberFinanceContext _context;
        public AddMaterialViewModelController(ProductsServices services, FiberFinanceContext context)
        {
            _productServices = services;
            _context = context;
        }




        public IActionResult Materials(int Id)
        {

            var Materials = _productServices.GetMaterials();
            var  id = _context.Product.Find(Id);
   


            var viewModel = new AddMaterialViewModel()
            {


                id,

                Materials = Materials



            };

            ViewData["Title"] = id.Name;
            return View(viewModel);
        }
    }
}
