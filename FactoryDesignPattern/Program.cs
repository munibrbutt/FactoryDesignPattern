using FactoryDesignPattern.Enums;
using System;

namespace FactoryDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var factory = new Thermostat().ExecuteCreate(Actions.Cooling, 17.5);
            factory.Control();
            factory = new Thermostat().ExecuteCreate(Actions.Warming, 21.5);
            factory.Control();
            Console.ReadKey();
        }
    }
}
