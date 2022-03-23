using System;

namespace ClassTaxi
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
}