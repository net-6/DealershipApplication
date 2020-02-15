using DealershipApp.Models;
using System;

namespace DealershipApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fordStore = new Store("FordStore")
            {
                Location = "Bucuresti",
                PhoneNumber = "0243987876",
            };

            var skodaStore = new Store("SkodaStore")
            {
                Location = "Bucuresti",
                PhoneNumber = "0243785676",
            };

            var alexCustomer = new Customer("Alex", "Florescu", new DateTime(1995, 11, 24), Enums.Gender.Male);

            var fordProducer = new Producer("Ford Productions");
            var fordCar1 = fordProducer.ProduceCar("Sedan", "Ford Focus", 2015);

            var skodaProducer = new Producer("Skoda Productions");
            var skodaCar1 = skodaProducer.ProduceCar("Sedan", "Skoda Fabia", 2015);

            fordStore.AddCar(fordCar1, 15000);
            skodaStore.AddCar(skodaCar1, 14000);

            Console.WriteLine(alexCustomer.Walk() + $" into the {fordStore.Name} in {fordStore.Location}.\n" +
                $"He agreed to buy a {fordCar1.ModelName} {fordCar1.ProductionYear} for {fordStore.Stock[0].Price} euros.");

            var order1 = new Order(alexCustomer, fordCar1, 4);

            Console.WriteLine($"They informed him it will take {order1.WeeksToDeliver} weeks to deliver his car.");

            Console.WriteLine($"\nHe then decided to visit {skodaStore.Name}.\n" +
                $"He agreed to buy a {skodaCar1.ModelName} {skodaCar1.ProductionYear} for {skodaStore.Stock[0].Price} euros.");

            var order2 = new Order(alexCustomer, skodaCar1, 3);

            Console.WriteLine($"They informed him it will take {order2.WeeksToDeliver} weeks to deliver his car.");

            Console.WriteLine($"\nHe then canceled his original order (nr. {order1.OrderNumber}) from {fordStore.Name}.");

            order1.ChangeStatus(Enums.OrderStatus.Canceled);

            Console.WriteLine($"After {order2.WeeksToDeliver} weeks, he received his {skodaCar1.ModelName}.");

            alexCustomer.BuyCar(skodaCar1, skodaStore);

            Console.ReadKey();
        }
    }
}
