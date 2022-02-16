using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public class Train : Transport
    {

        public double NumberOfWagons { get; set; }
        public string Manufacturer { get; set; }
        public Train(double numberOfWagons, double kilometers, string manufacturer)
        {
            Kilometers = kilometers;
            NumberOfWagons = numberOfWagons;
            Manufacturer = manufacturer;
        }
        public Train(string visitedPlaces)
        {
            VisitedPlaces = visitedPlaces;
        }
        public override double GetKilometers()
        {
            return Kilometers;
        }
        public override string GetVisitedPlaces()
        {
            return VisitedPlaces;
        }

        public override string GetInfo()
        {
            return $"Train ({Manufacturer}, {NumberOfWagons}) : {Kilometers} km";
        }
    }
}
