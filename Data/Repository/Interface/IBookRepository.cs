using MongoDB.Bson.Serialization.Attributes;
using StructureMongo.Domain.Entities;

namespace StructureMongo.Repository.Interface
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAll(CancellationToken cancellationToken);
        Task<Book> Get(string id, CancellationToken cancellationToken);
        Task Post(Book book, CancellationToken cancellationToken);
        Task<Book> Put(Book book, string id, CancellationToken cancellationToken);
    }
}
