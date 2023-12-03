using Builder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.OtherClasses
{
    internal class Director
    {
        public IBuilder builder;
        public Director()
        {
            
        }
        public void makeSUV(IBuilder builder) { }
        public void makeSportsCar(IBuilder builder) { }
    }
}
