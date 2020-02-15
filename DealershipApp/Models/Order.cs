using DealershipApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DealershipApp.Models
{
    class Order : IOrder
    {
        private readonly int orderNumber;
        public int OrderNumber { get { return orderNumber; } }
        public List<Car> CarsOrdered { get; set; }
        public Car CarOrdered { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int WeeksToDeliver { get; set; }
        public Enums.OrderStatus Status { get; set; }
        public decimal TotalPrice
        {
            get
            {
                if (CarsOrdered.Any()) // If there are more than one cars in an order, TotalPrice will be equal to the sum of their prices.
                {
                    decimal totalPrice = 0M;
                    foreach (var car in CarsOrdered)
                    {
                        totalPrice += car.Price;
                    }
                    return totalPrice;
                }
                else
                {
                    return CarOrdered.Price;
                }
            }
        }

        static int numberOfOrder = 1160;

        public Order(Customer customer, List<Car> cars, int weeksToDeliver)
        {
            CarsOrdered = cars;
            WeeksToDeliver = weeksToDeliver;
            this.orderNumber = numberOfOrder;
            numberOfOrder++;
            DeliveryDate = DateTime.Now.AddDays(weeksToDeliver * 7);
            customer.Orders.Add(this);
        }

        public Order(Customer customer, Car car, int weeksToDeliver)
        {
            CarOrdered = car;
            WeeksToDeliver = weeksToDeliver;
            this.orderNumber = numberOfOrder;
            numberOfOrder++;
            DeliveryDate = DateTime.Now.AddDays(weeksToDeliver * 7);
            customer.Orders.Add(this);
        }

        public void ChangeStatus(Enums.OrderStatus status)
        {
            Status = status;
        }


    }
}
