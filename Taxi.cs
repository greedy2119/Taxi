using System;
using System.Collections.Generic;
using System.Text;

namespace Taxi
{
    class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool Onduty;
        public int NumPassenger { get; set; }

        //buat objek mahasiswa


        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);


            if (Onduty == true)
            {
                Console.WriteLine("Onduty: yes", Onduty);
            }
            else
            {
                Console.WriteLine("Onduty: no", Onduty);
            }
            Console.WriteLine("NumPassenger: {0}\n", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang menjemput Penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Selesai Menantar Penumpang\n", DriverName);
        }
    }
}
