using System;


namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport[] transports = new Transport[4];
            transports[0] = new Car(25000, "BMW", "Red");
            transports[1] = new Train(28, 55000, "Stalder");
            transports[2] = new Taxi("Bolt", 10000, "Tesla", "Yellow");
            transports[3] = new Bike(2000, "BMX", "Black");
            transports[0].ZeroingMilege();
            transports[0].Drive("Zhytomyr", 15);
            transports[1].Drive("Kyiv", 150);
            transports[2].Drive("Kharkiv", 600);
            transports[3].Drive("Lviv", 350);
            double totalKm = 0;
            for (int i = 0; i < transports.Length; i++)
            {
                Console.WriteLine(transports[i].GetInfo());
                totalKm += transports[i].GetKilometers();
            }
            Console.WriteLine($"\nTotal kilometrage: {totalKm}");
            Console.WriteLine("\nVisited locations:");
            for (int i = 0; i < transports.Length; i++)
            {
                Console.WriteLine(transports[i].GetVisitedPlaces());
            }
        }
    }
}
