namespace FiberFinance.Models
{
    public class RawMaterialModel
    {
        public int Rmaterial { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }

        public float Price { get; set; }

        public RawMaterialModel(int rmaterial, string name, int amount, float price)
        {
            Rmaterial = rmaterial;
            Name = name;
            Amount = amount;
            Price = price;
        }

        public void AddMaterial(RawMaterialModel material) { }
        public void RemoveMaterial(RawMaterialModel material) { }      
        public void UpdateMaterial(RawMaterialModel material) { }
        public void ListMaterial() { }
        public void FindMaterial() { }


    }


}
