using System;

namespace Tugas
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }
    
        public void TaxiInfo(){
            Console.WriteLine("Driver Name: {0}",DriverName);
            Console.WriteLine("On Duty: {0}", OnDuty);
            Console.WriteLine("Number of Passenger: {0}",NumPassenger);
        }
        public void PickUpPassenger(){
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void PickOffPassenger(){
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Taxi driver1 = new Taxi();

            driver1.DriverName = "Taufik";
            driver1.OnDuty = true;
            driver1.NumPassenger = 5;

            driver1.TaxiInfo();
            Console.WriteLine();
            driver1.PickUpPassenger();
            driver1.PickOffPassenger();

            Console.ReadKey();
        }
    }
}
