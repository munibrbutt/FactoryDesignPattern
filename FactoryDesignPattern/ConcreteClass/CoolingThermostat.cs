using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace FactoryDesignPattern.ConcreteClass
{
    public class CoolingThermostat : IThermostat
    {
        private readonly double _temp;
        public CoolingThermostat(double temp )
        {
            _temp = temp;
        }
        public void Control()
        {
            Console.WriteLine($"Cooling the house to {_temp} degrees");
        }
    }
}
