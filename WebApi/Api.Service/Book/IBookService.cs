using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Service
{
    public interface IBookService : IRepository<Api.Data.Book>
    {
        IEnumerable<Api.Data.Book> GetBooksByGenre(string Genre);
    }
}
