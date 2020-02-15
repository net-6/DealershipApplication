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

        //This method instantiates a new car and adds it to the producers stock.
        public Car ProduceCar(string modelName, int productionYear, string carType)
        {
            var producedCar = new Car(this, modelName, productionYear, carType);
            this.CarsProduced.Add(producedCar);
            return producedCar;

        }

        public void DesignCar()
        {
            Console.WriteLine("A new car has been designed.");
        }
    }
}
