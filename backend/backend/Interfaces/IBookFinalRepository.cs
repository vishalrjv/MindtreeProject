using backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Interfaces
{
    public interface IBookFinalRepository
    {
        Task<IEnumerable<BookFinal>> GetBookDetails();
        void AddBookDetail(BookFinal bookfinal);
    }
}
