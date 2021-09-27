using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class BookDetail
    {
        [Key]
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }
        public string BookName { get; set; }
        public string Category { get; set; }
        
    }
}
