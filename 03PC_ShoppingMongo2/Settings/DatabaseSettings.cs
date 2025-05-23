namespace _03PC_ShoppingMongo2.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public string CategoryCollectionName { get; set; }

        public string ProductCollectionName { get; set; }

        public string SliderCollectionName { get; set; }

        public string ProductImageCollectionName { get; set; }
    }
}
