using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interface
{
    internal interface IBuilder
    {
        public void reset();
        public void setSeats(int number);
        public void setEngine(IEngine engine);
        public void setTripComputer();
        public void setGPS();

    }
}
