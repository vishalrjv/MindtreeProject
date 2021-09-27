using backend.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Interfaces
{
     public interface IOrderService
    {
        void CreateOrder( OrdersDto orderDetails);
        List<OrdersDto> GetOrderList();
    }
}
