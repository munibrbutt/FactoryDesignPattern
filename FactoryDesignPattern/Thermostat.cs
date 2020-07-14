using FactoryDesignPattern.Enums;
using FactoryDesignPattern.FactoryClass;
using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class Thermostat
    {
        private readonly Dictionary<Actions, ThemostatFactory> _factories;

        public Thermostat()
        {
            _factories = new Dictionary<Actions, ThemostatFactory>();
            foreach (Actions action in Enum.GetValues(typeof(Actions)))
            {
                var factory = (ThemostatFactory)Activator.CreateInstance(Type.GetType("FactoryDesignPattern.FactoryClass." + Enum.GetName(typeof(Actions), action) + "ThermostatFactory"));
                _factories.Add(action, factory);
            }

        }
        public IThermostat ExecuteCreate(Actions action, double temp) => _factories[action].Create(temp);
    }
}
