using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public class Bike : Transport
    {

        public string Model { set; get; }
        public string Color { set; get; }
        public Bike(double kilometers, string model, string color)
        {
            Kilometers = kilometers;
            Model = model;
            Color = color;
        }
        public Bike(string visitedPlaces)
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
            return $"Bike ({Model}, {Color}) : {Kilometers} km";
        }
    }
}
