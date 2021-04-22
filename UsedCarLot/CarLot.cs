using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class CarLot 
    {
        List<Car> cars = new List<Car>
        {
            new Car("Nikolai Model","S", 2017, 54999.90),
            new Car("Fourd", "Escapade", 2017, 31999),           
            new Car("Chewie", "Vette", 2017, 44989.95),
            new UsedCar("Hyonda", "Prior", 2015, 14795.50, 35987.6),
            new UsedCar(" GC ","Chirpus", 2013, 8500.00, 12345.0),
            new UsedCar("GC", "Witherell", 2016, 14450.00, 3500.3)           
        };

         

      
        public static List<Car> AddCar(List<Car> cars)           
        {
            Console.WriteLine("Enter make of car");
            string choice1 = Console.ReadLine();
            Console.WriteLine("Enter model of car");
            string choice2 =Console.ReadLine();
            Console.WriteLine("Enter year of car");
            int choice3 =int.Parse(Console.ReadLine());
            Console.WriteLine("How much does it cost");
            double choice4 = double.Parse(Console.ReadLine());
            Car newcar = new Car(choice1, choice2, choice3, choice4);
            cars.Add(newcar);
            return cars;

        }

    }
}
