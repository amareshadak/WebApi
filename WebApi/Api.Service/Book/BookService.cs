using Api.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Service
{
  
    public class BookService : Repository<Api.Data.Book>, IBookService
    {
        public BookService(ApiContext context) : base(context)
        {

        }

        public IEnumerable<Api.Data.Book> GetBooksByGenre(string Genre)
        {
            return _context.Books.Where(x => x.Genre == Genre);
        }

    }
}
