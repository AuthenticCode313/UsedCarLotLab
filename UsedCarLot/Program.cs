using System;
using System.Collections.Generic;

namespace UsedCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            Console.Beep(300, 200);
            Console.WriteLine("Welcome to the car shop, here is our inventory of cars");
            while (runProgram)
            {
                CarLot carlot = new CarLot();
                carlot.DisplayAllCars();
                Console.WriteLine("Which car would you like?");
                int choice = int.Parse(Console.ReadLine());
                if (choice == carlot.Cars.Count + 1)
                {
                    carlot.AddCar();
                }
                else if (choice < carlot.Cars.Count)
                {
                    Console.WriteLine("Would you like to buy this car?");
                   //would be removing car here
                }
                else if (choice == carlot.Cars.Count+2)
                {
                    break;                   
                } 

                Console.WriteLine("Would you like to buy another car? y/n");
                string result = Console.ReadLine();
                while (true) 
                {
                    if (result == "n")
                    {
                        runProgram = false;
                        break;
                    } else
                    {
                        break;
                    }

                }
            }
        }

        
    }
}
