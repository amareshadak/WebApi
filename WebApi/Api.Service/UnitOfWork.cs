using Api.Data.Context;
using System;


namespace Api.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApiContext _context;
        public IUserService User { get; }
        public IBookService Book { get; }
        public UnitOfWork(
            ApiContext context,
          IBookService bookService
            )
        {
            this._context = context;
            // this.User = userService;
            this.Book = bookService;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
