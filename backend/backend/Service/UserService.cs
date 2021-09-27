using backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Service
{
    public class UserService
    {
        private readonly backendcontext context;

        public UserService()
        {
            context = new backendcontext();
        }
        public bool AddBookDetails(book book)
        {
            context.books.Add(book);
            int RowsAffected = context.SaveChanges();
            return RowsAffected == 1;
        }
        public List<book> GetBookDetailsByAuthorName(int id,string AuthorName)
        {
            var query = from obj in context.books.Include(user => user.User)
                        where obj.AuthorName == AuthorName && obj.UId == id
                        select obj;
            if (query != null)
                return query.ToList();
            return null;
        }
        public List<book> GetAllBooks()
        {
            return context.books.ToList();
        }
    }
}
