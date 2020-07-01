using FactoryDesignPattern.ConcreteClass;
using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.FactoryClass
{
    public class CoolingThermostatFactory : ThemostatFactory
    {
        public override IThermostat Create(double temp) =>
            new CoolingThermostat(temp);        
    }
}
