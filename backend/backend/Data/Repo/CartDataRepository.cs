using backend.Interfaces;
using backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Data.Repo
{
    public class CartDataRepository:ICartService
    {
        readonly backendcontext _dbContext;

        public CartDataRepository(backendcontext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBookToCart(int bookId)
        {
            throw new NotImplementedException();
        }

        public int ClearCart()
        {
            throw new NotImplementedException();
        }

        public string GetCartId()
        {
            throw new NotImplementedException();
        }

        public int GetCartItemCount(int userId)
        {
            throw new NotImplementedException();
        }

        public void MergeCart(int permUserId)
        {
            throw new NotImplementedException();
        }

        public void RemoveCartItem(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
