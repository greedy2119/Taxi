using System;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            //pengesetan nilai mahasiswa
            taxi.DriverName = "Jono";
            taxi.Onduty = true;

            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
            Console.ReadKey();

        }
    }
}
