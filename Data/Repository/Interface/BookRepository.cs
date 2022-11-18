using MongoDB.Driver;
using StructureMongo.Data;
using StructureMongo.Domain.Entities;

namespace StructureMongo.Repository.Interface
{
    public class BookRepository : IBookRepository
    {
        IMongoCollection<Book> _books;

        public BookRepository(MongoDb mongoDB)
        {
            _books = mongoDB.DB.GetCollection<Book>("book");
        }

        public async Task<Book> Get(string id, CancellationToken cancellationToken)
        {

            return _books.AsQueryable().FirstOrDefault(_ => _.Id == id);
        }

        public async Task<List<Book>> GetAll(CancellationToken cancellationToken)
        {
            return default;
        }

        public Task Post(Book book, CancellationToken cancellationToken)
        {
            _books.InsertOne(book, cancellationToken: cancellationToken);

            return Task.CompletedTask;
        }

        public Task<Book> Put(Book book, string id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
