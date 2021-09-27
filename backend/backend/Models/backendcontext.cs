using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class backendcontext:DbContext
    {
        public backendcontext()
        {
        }

        public backendcontext(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<userloginnew> userloginnews { get; set; }
        public DbSet<book> books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<BookFinal> bookFinals { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<CartItems> CartItems { get; set; }
        public virtual DbSet<CustomerOrderDetails> CustomerOrderDetails { get; set; }
        public virtual DbSet<CustomerOrder> CustomerOrders { get; set; }
    }
}

