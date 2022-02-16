using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public abstract class Transport
    {

        public double Kilometers { set; get; }
        public string VisitedPlaces;
        public abstract double GetKilometers();
        public abstract string GetVisitedPlaces();
        public abstract string GetInfo();
        public void Drive(string visitedPlaces, double km)
        {
            Kilometers += km;
            VisitedPlaces = visitedPlaces;
        }

        public void ZeroingMilege()
        {
            Kilometers = 0;
        }
        public double GetMileage()
        {
            return Kilometers;
        }
    }

}

