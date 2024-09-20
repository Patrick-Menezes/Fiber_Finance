using NuGet.Protocol.Plugins;
using System.Collections.Generic;
namespace FiberFinance.Models
{
    public class Product
    {


        public int Id { get; set; }
        public Item Item { get; set; }
        public ICollection<RawMaterial> Materials { get; set; }= new List<RawMaterial>();

        public Product() { }

        public Product(int id, Item item)
        {
            Id = id;
            Item = item;
        }



        public void AddMaterial(RawMaterial material)
        {
            Materials.Add(material);


        }



    }


}
