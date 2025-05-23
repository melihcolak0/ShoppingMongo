namespace _03PC_ShoppingMongo2.DTOs.ProductDTOs
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }

        public string Gender { get; set; }

        public string Description { get; set; }

        public decimal ProductPrice { get; set; }

        public bool Status { get; set; }

        public int StockCount { get; set; }

        public string CategoryId { get; set; }
    }
}
