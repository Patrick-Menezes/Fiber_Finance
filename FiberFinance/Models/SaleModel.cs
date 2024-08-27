namespace FiberFinance.Models
{
    public class SaleModel
    {
        public int SaleId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? DeliveryEstimate{get; set; }
        public DateTime? DeliveryDate { get; set; }
        public List<ProductModel> Products { get; set; }

        public SaleModel(int saleId, DateTime orderDate, DateTime? deliveryEstimate, DateTime? deliveryDate)
        {
            SaleId = saleId;
            OrderDate = orderDate;
            DeliveryEstimate = deliveryEstimate;
            DeliveryDate = deliveryDate;
        }

        public void AddSale() { }
        public void UpdateSale() { }
        public void DeleteSale() { }
        public void ListSales() { }
        public void FindOrder() { }
        public void CalculateTotal() { }


    }
}
