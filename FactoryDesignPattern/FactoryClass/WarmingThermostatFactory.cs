using FactoryDesignPattern.ConcreteClass;
using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.FactoryClass
{
    public class WarmingThermostatFactory : ThemostatFactory
    {
        public override IThermostat Create(double temp) =>
            new WarmingThermostat(temp);
        
    }
}
