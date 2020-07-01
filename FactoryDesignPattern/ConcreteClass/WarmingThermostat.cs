using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.ConcreteClass
{
    public class WarmingThermostat : IThermostat
    {
        private readonly double _temp;
        public WarmingThermostat(double temp)
        {
            _temp = temp;
        }

        public void Control()
        {
            Console.WriteLine($"Warming the house to {_temp} degrees");
        }
    }
}
