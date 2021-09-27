using backend.Data.Repo;
using backend.Interfaces;
using backend.Models;
using backend.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly backendcontext dc;

        public UnitOfWork(backendcontext dc)
        {
            this.dc = dc;
        }
        public IUserRepository UserRepository => new UserRepository(dc);

        public IBookFinalRepository BookFinalRepository =>  new BookFinalRepository(dc);

        public async Task<bool> SaveAsync()
        {
            return await dc.SaveChangesAsync() > 0;
        }
    }
}
