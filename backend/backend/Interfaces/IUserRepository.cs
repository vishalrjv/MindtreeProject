using backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Interfaces
{
    public interface IUserRepository
    {
        Task<userloginnew> Authenticate(string EmailId, string Password);
        void Register(string EmailId, string Password);

        Task<bool> UserAlreadyExists(string EmailId);
    }
}
