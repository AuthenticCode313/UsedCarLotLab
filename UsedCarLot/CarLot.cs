using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class CarLot 
    {
        private List<Car> _cars;
        public List<Car> Cars
        {
            get { return this._cars; }
            set { this._cars = value; }
        }

        public CarLot()
        {
            StoreList();
        }

        
        private void StoreList() 
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
            this._cars = cars;
        }

        
        public void RemoveCar()
        {
            Console.WriteLine("Which car would you like to choose?");
            int choice = int.Parse(Console.ReadLine());

            
            
            
        }

        public void AddCar()           
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
            //cars.Add(newcar);          
        }

        public void DisplayAllCars()
        {
            int counter = 1;
            foreach (Car car in this._cars)
            {
                Console.WriteLine($"{counter} {car.ToString()}");               
                counter++;
            }
            Console.WriteLine(counter + "Add a car");
            counter++;
            Console.WriteLine(counter + "Quit");
            
        }

    }
}
