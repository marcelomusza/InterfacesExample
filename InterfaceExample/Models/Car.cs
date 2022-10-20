using InterfaceExample.Contracts;

namespace InterfaceExample.Models
{
    public class Car : IVehiculo
    {
        public int Gasoline { get; set; }

        public Car(int gasoline)
        {
            Gasoline = gasoline;
        }

        public void Drive()
        {
            if (Gasoline > 0)
                Console.WriteLine("Car is driving!");
            else
                Console.WriteLine("Car has no fuel!");            
        }

        public bool Refuel(int amount)
        {
            Gasoline += amount;
            return true;
        }
    }
}
