using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace _03PC_ShoppingMongo2.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }
    }
}
