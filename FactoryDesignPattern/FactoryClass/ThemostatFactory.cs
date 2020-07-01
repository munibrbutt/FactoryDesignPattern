using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.FactoryClass
{
    public abstract class ThemostatFactory
    {
        public abstract IThermostat Create(double temp);
    }
}
