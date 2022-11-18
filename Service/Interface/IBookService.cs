using MongoDB.Bson.Serialization.Attributes;
using StructureMongo.Domain.Entities;

namespace StructureMongo.Service.Interface
{
    public interface IBookService
    {
        Task<Book> GetAll(CancellationToken cancellationToken);
        Task<Book> Get(string id, CancellationToken cancellationToken);
        Task Post(Book book, CancellationToken cancellationToken);
        Task<Book> Put(Book book, Guid id, CancellationToken cancellationToken);
    }
}
