using FiberFinance.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using FiberFinance.services;
using FiberFinance.Models;
namespace FiberFinance.Controllers;

public class ProductsController : Controller
{
    private readonly ProductsServices _productsServices;
    private readonly FiberFinanceContext _context;

    public ProductsController(ProductsServices productsServices, FiberFinanceContext context)
    {
        _productsServices = productsServices;
        _context = context;
    }





    public async Task<IActionResult> Index()
    {
        return View(await _context.Product.ToListAsync());
    }


    public async Task<IActionResult> Create()
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