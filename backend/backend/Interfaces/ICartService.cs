using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Interfaces
{
    public interface ICartService
    {
        void AddBookToCart( int bookId);
       
        int GetCartItemCount(int userId);
        void MergeCart( int permUserId);
        int ClearCart();
        string GetCartId();
    }
}
