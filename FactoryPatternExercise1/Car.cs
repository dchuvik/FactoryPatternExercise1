using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    public class Car : IVehicle
    {
        public Car()
        {
        }
        public void Drive()
        {
            Console.WriteLine("Building a new Car!");
        }
    }
}
