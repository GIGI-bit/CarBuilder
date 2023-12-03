using Builder.Interface;
using Builder.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CarClasses
{
    internal class CarBuilder : IBuilder
    {
        private Car car;
        public CarBuilder()
        {
            
        }
        public void reset()
        {
            Console.WriteLine("reset");
        }

        public void setEngine(IEngine engine)
        {
            Console.WriteLine("Engine is Set");
        }

        public void setGPS()
        {
            Console.WriteLine("GPS s set.");
        }

        public void setSeats(int number)
        {
            Console.WriteLine("Seats are set");
        }

        public void setTripComputer()
        {
            Console.WriteLine("Trip Computers are set");
        }
        public Car getCar() { return  car; }
    }
}
