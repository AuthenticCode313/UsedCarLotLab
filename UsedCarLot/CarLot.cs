using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class CarLot 
    {
        List<Car> car = new List<Car>
        {
            new Car("Nikolai Model","S", 2017, 54999.90),
            new Car("Fourd", "Escapade", 2017, 31999),           
            new Car("Chewie", "Vette", 2017, 44989.95),
            new UsedCar("Hyonda", "Prior", 2015, 14795.50, 35987.6),
            new UsedCar(" GC ","Chirpus", 2013, 8500.00, 12345.0),
            new UsedCar("GC", "Witherell", 2016, 14450.00, 3500.3)

        };
    }
}
