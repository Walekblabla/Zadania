using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Changes.BusinessLogic
{
    public class FuelBusinessLogic
    {
        public double CalculateAvgConsumption(int fuel, int distance)
        {
            double avg = (double)fuel / distance;
            return avg * 100;
        }
    }
}