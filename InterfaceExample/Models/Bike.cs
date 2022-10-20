using InterfaceExample.Contracts;

namespace InterfaceExample.Models
{
    public class Bike : IVehiculo
    {
        public int Gasoline { get; set; }
        public Bike(int gasoline)
        {
            Gasoline = gasoline;
        }

        public void Drive()
        {
            Console.WriteLine("Driving the Bike!");
        }

        public bool Refuel(int amount)
        {
            Gasoline += amount;
            return true;
        }
    }
}
