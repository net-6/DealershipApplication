using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp
{
    public class Enums
    {
        public enum Gender
        {
            Male,
            Female
        }

        public enum OrderStatus
        {
            OnHold,
            Shipped,
            Delayed,
            Placed,
            Canceled
        }
    }
}
