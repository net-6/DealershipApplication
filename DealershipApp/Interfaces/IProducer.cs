using DealershipApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp.Interfaces
{
    interface IProducer
    {
        Car ProduceCar(string modelName, int productionYear, string carTyp);
        void DesignCar();
    }
}
