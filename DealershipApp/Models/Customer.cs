using DealershipApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp.Models
{
    class Customer : Person
    {
        public string PhoneNumber { get; set; }
        public List<Order> Orders { get; set; }
        public List<Car> CarsOwned { get; set; }

        public Customer(string firstName, string lastName, DateTime birthDate, Enums.Gender gender) : base(firstName, lastName, birthDate, gender)
        {
            Orders = new List<Order>();
            CarsOwned = new List<Car>();
        }
        public void BuyCar(Car carBought, Store store)
        {
            CarsOwned.Add(carBought);
            store.Stock.Remove(carBought);
        }
        public override string Talk()
        {
            return $"{FullName} is talking";

        }

        public override string Walk()
        {
            return $"{FullName} is walking";
        }
    }
}
