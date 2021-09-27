using backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos
{
    public class CartItemDto
    {
        public BookFinal Book { get; set; }
        public int Quantity { get; set; }
    }
}
