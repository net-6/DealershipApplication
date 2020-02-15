using DealershipApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp.Models
{
    class Car : IVehicle
    {
        private readonly Producer producer;
        private readonly string modelName;
        private readonly int productionYear;
        private readonly string carType;

        public Producer Producer { get { return producer; } }
        public string ModelName { get { return modelName; } }
        public string CarType { get; set; }
        public int ProductionYear { get { return productionYear; } }

        public decimal Price { get; set; }

        public Car(Producer producer, string modelName, int productionYear, string carType)
        {
            this.producer = producer;
            this.modelName = modelName;
            this.productionYear = productionYear;
            CarType = carType;
        }
        public void Move()
        {
            Console.WriteLine($"{ModelName} is moving.");
        }

        public void Stop()
        {
            Console.WriteLine($"{ModelName} has stopped.");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{ModelName} has been turned off.");
        }

        public void TurnOn()
        {
            Console.WriteLine($"{ModelName} has been turned on.");
        }
    }
}
