using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Taxi : Car
    {

        public string Company { set; get; }
        public Taxi(string company, double kilometers, string manufacturer, string color) : base(kilometers, manufacturer, color)
        {
            Kilometers = kilometers;
            Company = company;
        }
        public Taxi(string visitedPlaces) : base(visitedPlaces)
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
            return $"Taxi ({Company}, {Manufacturer}, {Color}) : {Kilometers} km";
        }
    }
}
