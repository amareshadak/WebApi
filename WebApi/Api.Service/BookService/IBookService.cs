using Api.Core.Domain;
using System.Collections.Generic;

namespace Api.Service
{
    public interface IBookService : IRepository<Book>
    {
        IEnumerable<Book> GetBooksByGenre(string Genre);
    }
}
