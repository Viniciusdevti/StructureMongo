using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StructureMongo.Domain.Entities
{
    public class Book
    {
        public Book(string name, string category)
        {
            Name = name;
            Category = category;
        }

        public Book(string id, string name, string category)
        {
            Id = id;
            Name = name;
            Category = category;
        }
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Category { get; private set; }
    }
}
