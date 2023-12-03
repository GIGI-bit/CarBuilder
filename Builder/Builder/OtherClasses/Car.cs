using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interface;

namespace Builder.OtherClasses
{
    internal class Car
    {
        public string Color { get; set; }
        public string Model { get; set; }
        public string Vendor { get; set; }
        public IEngine Engin { get; set; }
        public Car() { }
    }
}
