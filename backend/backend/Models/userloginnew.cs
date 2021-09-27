using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class userloginnew
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string Password { get; set; }

        public virtual ICollection<book> books { get; set; }
        public virtual ICollection<BookDetail> BookDetails { get; set; }
    }
}
