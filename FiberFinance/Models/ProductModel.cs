namespace FiberFinance.Models
{
    public class ProductModel
    {
        public int ProductId{ get; set; }
        public string Name{ get; set; }
        public string Description{ get; set; }
        public float  Price { get; set; }

        public int CategoryId {  get; set; }

        public ProductModel(int productId, string name, string description, float price, int categoryId)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Price = price;
            CategoryId = categoryId;
        }

        public void AddProduct() {  }
        public void UpdateProduct() { }
        public void DeleteProduct() { }
        public void ListProducts() { }
        public void FindProduct() { }

    }

}
