using backend.Interfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Data.Repo
{
    public class BookFinalRepository : IBookFinalRepository
    {
        private readonly backendcontext dc;
        public BookFinalRepository(backendcontext dc)
        {
            this.dc = dc;
        }
        public void AddBookDetail(BookFinal bookfinal)
        {
            dc.bookFinals.Add(bookfinal);
        }

        public async Task<IEnumerable<BookFinal>> GetBookDetails()
        {
            var bookfinal = await dc.bookFinals.ToListAsync();
            return bookfinal;
        }
    }
}
