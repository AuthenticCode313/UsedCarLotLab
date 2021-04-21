using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class UsedCar : Car
    {
        private double _mileage;

        public double Mileage
        {
            get { return this._mileage; }
            set { this._mileage = value; }
        }

        public UsedCar(string make, string model, int year, double price, double mileage) : base(make, model, year, price)
        {
            this._mileage = mileage;
        }

        public override string ToString()
        {
            string result = base.ToString();
            return $"{result} Used {this._mileage}";
        }
    }
}
