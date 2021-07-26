using Api.Data;
using System;
using System.Threading.Tasks;

namespace Api.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApiContext _context;
        public IUserService User { get; }
        public IMemberService Member { get; }
        public UnitOfWork(
            ApiContext context,
          IUserService userService,
          IMemberService memberService
            )
        {
            this._context = context;
            this.User = userService;
            this.Member = memberService;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
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
