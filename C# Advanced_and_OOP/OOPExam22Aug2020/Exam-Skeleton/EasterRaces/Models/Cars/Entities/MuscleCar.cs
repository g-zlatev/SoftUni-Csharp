using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Entities
{
    public class MuscleCar : Car
    {
        private const int defaultCubicCentimeters = 5000;
        private const int defaultMinHorsePower = 400;
        private const int defaultMaxHorsePower = 600;


        public MuscleCar(string model, int horsePower) 
            : base(model, horsePower, defaultCubicCentimeters, defaultMinHorsePower, defaultMaxHorsePower)
        {
        }
    }
}
