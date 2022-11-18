using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace StructureMongo.Data
{
    public class MongoDb
    {
        public IMongoDatabase DB { get; }
        public MongoDb(IConfiguration configuration)
        {
            try
            {
                var client = new MongoClient(configuration["ConnectionString"]);
                DB = client.GetDatabase(configuration["NameDb"]);
            }
            catch (Exception ex)
            {
                throw new MongoException("Não foi possivel se conectar ao Mongo.", ex);
            }
        }

        
    }
}
