using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IBookFinalRepository BookFinalRepository { get; }
        Task<bool> SaveAsync();
    }
}
