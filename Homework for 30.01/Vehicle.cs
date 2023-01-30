using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_for_30._01_
{
    internal class Vehicle
    {
        public Vehicle(string Model,string Brand,double Milleage)
        {         
            this.Model = Model;
            this.Brand = Brand; 
            this.Milleage = Milleage;
        }



        public string Model;
        public string Brand;
        public double Milleage;

       
    }
}
