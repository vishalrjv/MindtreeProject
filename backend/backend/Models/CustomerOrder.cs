using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class CustomerOrder
    {
        [Key]
        public string OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal CartTotal { get; set; }
    }
}
