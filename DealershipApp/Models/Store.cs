using DealershipApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp.Models
{
    class Store : IStore
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public List<Car> Stock { get; set; }

        public Store(string name)
        {
            Stock = new List<Car>();
            Name = name;
        }
        public void AddCar(Car carToAdd, decimal price)
        {
            carToAdd.Price = price;
            Stock.Add(carToAdd);
            carToAdd.Producer.CarsProduced.Remove(carToAdd);
            
        }
        public void OpenStore()
        {
            Console.WriteLine($"{Name} is now open.");
        }

        public void CloseStore()
        {
            Console.WriteLine($"{Name} is now closed.");
        }
    }
}
