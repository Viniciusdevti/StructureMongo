using StructureMongo.Domain.Entities;
using StructureMongo.Repository.Interface;
using StructureMongo.Service.Interface;

namespace StructureMongo.Service
{
    public class BookService : IBookService
    {

        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Book> Get(string id, CancellationToken cancellationToken)
        {
            return await _bookRepository.Get(id, cancellationToken);
        }

        public Task<Book> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Post(Book book, CancellationToken cancellationToken)
        {
            _bookRepository.Post(book, cancellationToken);
            return Task.CompletedTask;
        }

        public Task<Book> Put(Book book, Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
