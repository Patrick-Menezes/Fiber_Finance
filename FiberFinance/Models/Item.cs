namespace FiberFinance.Models
{
    public class Item
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }


        public Item() { }

        public Item(int id, string name, string? description, float price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
