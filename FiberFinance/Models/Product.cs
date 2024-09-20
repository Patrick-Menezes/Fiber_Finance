using NuGet.Protocol.Plugins;
using System.Collections.Generic;
namespace FiberFinance.Models
{
    public class Product
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }


        public ICollection<RawMaterial> Materials { get; set; }= new List<RawMaterial>();

        public Product() { }

        public Product(int id, string name, string? description, float price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }



        public void AddMaterial(RawMaterial material)
        {
            Materials.Add(material);


        }



    }


}
