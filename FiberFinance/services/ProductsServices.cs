using FiberFinance.Data;
using FiberFinance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace FiberFinance.services
{
    public class ProductsServices
    {
        private readonly FiberFinanceContext _context;

        public ProductsServices(FiberFinanceContext context)
        {
            _context = context;
        }


        public void Insert(Product product)
        {
            _context.Add(product);
         
            _context.SaveChanges();
        
        }
      

        public List<Product> GetAll()
        {
            return _context.Product.ToList();
        }

    }
}
