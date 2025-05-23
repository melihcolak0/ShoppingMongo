namespace _03PC_ShoppingMongo2.DTOs.ProductDTOs
{
    public class ResultProductDto
    {
        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public string Gender { get; set; }

        public string Description { get; set; }

        public decimal ProductPrice { get; set; }

        public bool Status { get; set; }

        public int StockCount { get; set; }

        public string CategoryId { get; set; }

        public string CategoryName { get; set; }

        public List<string> ImageUrls { get; set; } = new List<string>();
    }
}
