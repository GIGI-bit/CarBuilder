using Builder.Interface;
using Builder.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CarClasses
{
    internal class CarManualBuilder : IBuilder
    {
        private Manual manual;
        public CarManualBuilder()
        {
            
        }
        public void reset()
        {
            throw new NotImplementedException();
        }

        public void setEngine(IEngine engine)
        {
            throw new NotImplementedException();
        }

        public void setGPS()
        {
            throw new NotImplementedException();
        }

        public void setSeats(int number)
        {
            throw new NotImplementedException();
        }

        public void setTripComputer()
        {
            throw new NotImplementedException();
        }
        public Manual GetManual() { return  manual; }
    }
}
