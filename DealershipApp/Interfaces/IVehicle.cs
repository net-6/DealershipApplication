using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp.Interfaces
{
    interface IVehicle
    {
        void TurnOn();
        void TurnOff();
        void Move();
        void Stop();
    }
}
