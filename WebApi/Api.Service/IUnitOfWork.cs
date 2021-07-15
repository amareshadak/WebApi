using System;
using System.Threading.Tasks;

namespace Api.Service
{
    public interface IUnitOfWork : IDisposable
    {
        IUserService User { get; }
        IBookService Book { get; }
        IMemberService Member { get; }
        int Complete();
        Task<int> CompleteAsync();
    }
}
