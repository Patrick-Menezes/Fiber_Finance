using FiberFinance.Data;
using FiberFinance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
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

        public List<RawMaterial> GetMaterials() 
        { 
        
           return _context.RawMaterial.OrderBy(x=>x.Name).ToList();
        }

      
       
        public List<Product> GetAll()
        {
            return _context.Product.ToList();
        }


        public Product FindById(int id)
        {
            return _context.Product.FirstOrDefault(x => x.Id == id);

        }

        public void Remove (int id)
        {
            var obj = _context.Product.Find(id);
            _context.Product.Remove(obj);
            _context.SaveChanges();
        }


        public void Update(Product product)
        { 
            _context.Product.Update(product);
            _context.SaveChanges();
        }

        public void AddMaterial(int productId, RawMaterial material)
        {

            var product = _context.Product.Include(x => x.Materials).FirstOrDefault(p => p.Id == productId);

          
            product.AddMaterial(material);

            _context.SaveChanges();


        }

    }
}
