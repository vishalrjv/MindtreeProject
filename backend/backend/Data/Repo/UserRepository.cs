using backend.Interfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace backend.Repo
{
    public class UserRepository : IUserRepository
    {
        private readonly backendcontext dc;
        public UserRepository(backendcontext dc)
        {
            this.dc = dc;
        }
        public async Task<userloginnew> Authenticate(string EmailId, string Password)
        {
            return await dc.userloginnews.FirstOrDefaultAsync(x => x.EmailId == EmailId &&x.Password==Password);
            
        }

        //private bool MatchPasswordHash(string passwordText, byte[] password, byte[] passwordKey)
        //{
        //    using (var hmac = new HMACSHA512(passwordKey))
        //    {
        //        var passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(passwordText));

        //        for (int i = 0; i < passwordHash.Length; i++)
        //        {
        //            if (passwordHash[i] != password[i])
        //                return false;
        //        }

        //        return true;
        //    }
        //}

        public void Register(string EmailId, string Password)
        {
            //byte[] passwordHash, passwordKey;

            //using (var hmac = new HMACSHA512())
            //{
            //    passwordKey = hmac.Key;
            //    passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Password));

            //}
            userloginnew user = new userloginnew();
            user.EmailId = EmailId;
            user.Password = Password;
            

            dc.userloginnews.Add(user);
        }

        public async Task<bool> UserAlreadyExists(string EmailId)
        {
            return await dc.UserLogins.AnyAsync(x => x.EmailId == EmailId);
        }
    }
}
