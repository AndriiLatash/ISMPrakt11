using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Car : Transport
    {

        public string Manufacturer { set; get; }
        public string Color { set; get; }

        public Car(double kilometers, string manufacturer, string color)
        {
            Kilometers = kilometers;
            Manufacturer = manufacturer;
            Color = color;
        }
        public Car(string visitedPlaces)
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
            return $"Taxi ({Manufacturer}, {Color}) : {Kilometers} km";
        }

    }
}
