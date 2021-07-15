using Api.Core.Domain;
using Api.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Api.Service
{

    public class BookService : Repository<Book>, IBookService
    {
        public BookService(ApiContext context) : base(context)
        {

        }

        public IEnumerable<Book> GetBooksByGenre(string Genre)
        {
            return _context.Books.Where(x => x.Genre == Genre);
        }

    }
}
