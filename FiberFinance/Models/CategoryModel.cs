namespace FiberFinance.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public CategoryModel(int categoryId, string name, string description)
        {
            CategoryId = categoryId;
            Name = name;
            Description = description;
        }

  public void AddCategory() { } 
  public void RemoveCategory() { }
  public void UpdateCategory() { }
  public void ListCategory() { }
  public void FindCategory() { }


    }

}
