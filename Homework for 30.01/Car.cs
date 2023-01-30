using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_for_30._01_
{
    internal class Car:Vehicle
    {
        public Car(string Model, string Brand, double Milleage, double FuelCapacity, double CurrentFuel) : base(Model, Brand, Milleage)
        {           
            this.FuelCapacity = FuelCapacity;
            this.CurrentFuel = CurrentFuel;
        }

        public double FuelCapacity;
        public double CurrentFuel;

        public void AddFuel(double lt)
        {
            if(CurrentFuel+lt <= FuelCapacity)
            {
                CurrentFuel += lt;
            }

        }
        
    }
}
