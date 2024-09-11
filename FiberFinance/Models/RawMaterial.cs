namespace FiberFinance.Models
{
    public class RawMaterial
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }

        public RawMaterial() { }
        public RawMaterial(int id, string name, int amount, float price)
        {
            Id = id;
            Name = name;
            Amount = amount;
            Price = price;
        }






     

    }


}
