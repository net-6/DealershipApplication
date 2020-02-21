using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp.Interfaces
{
    interface IOrder
    {
        void ChangeStatus(Enums.OrderStatus status);
    }
}
