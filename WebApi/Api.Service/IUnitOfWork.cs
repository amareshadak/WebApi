using System;

namespace Api.Service
{
    public interface IUnitOfWork : IDisposable
    {
        IUserService User { get; }
        IBookService Book { get; }
        int Complete();
    }
}
