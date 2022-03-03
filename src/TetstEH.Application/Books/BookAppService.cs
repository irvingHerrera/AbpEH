using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using System.Linq;

namespace TetstEH.Books
{
    public class BookAppService : TetstEHAppService, IBookAppService
    {
        private readonly IRepository<Book, Guid> _repository;
        public BookAppService(IRepository<Book, Guid> repository)
        {
            _repository = repository;
        }

        public async Task CreateBook()
        {
            var book = new Book
            {
                Name = GuidGenerator.Create().ToString(),
                PublishDate = Clock.Now,
                Type = BookType.Undefined,
                Price = (float)new Random(Clock.Now.Millisecond).NextDouble(),
            };

           await _repository.InsertAsync(book);
        }

        // this is only to record a service call
        public async Task GetAllBooks()
        {
            var all = await _repository.GetListAsync();
            var book = all.FirstOrDefault();
            // more code ...
        }

        public async Task UpdateBook()
        {
            var book = await _repository.FirstOrDefaultAsync();

            if (book == null)
            {
                throw new UserFriendlyException("Not found");
            }

            book.Name = GuidGenerator.Create().ToString();
            book.Price = (float)new Random(Clock.Now.Millisecond).NextDouble();

            await _repository.UpdateAsync(book);
        }
    }
}
