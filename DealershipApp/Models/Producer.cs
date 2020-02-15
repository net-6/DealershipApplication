using DealershipApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp.Models
{
    class Producer : IProducer
    {
        public string Name { get; set; }
        public List<Car> CarsProduced { get; set; }

        public Producer(string name)
        {
            Name = name;
            CarsProduced = new List<Car>();
        }

        public Car ProduceCar(string carType, string modelName, int productionYear)
        {
            var producedCar = new Car(this, modelName, productionYear)
            {
                CarType = carType,
            };
            this.CarsProduced.Add(producedCar);
            return producedCar;

        }

        public void DesignCar()
        {
            Console.WriteLine("A new car has been designed.");
        }
    }
}
