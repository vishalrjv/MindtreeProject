using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Cart
    {
        [Key]
        public string CartId { get; set; }
        public DateTime createdAt { get; set; }
    }
}
