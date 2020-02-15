using DealershipApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp.Interfaces
{
    interface IProducer
    {
        Car ProduceCar(string carType, string modelName, int productionYear);
        void DesignCar();
    }
}
