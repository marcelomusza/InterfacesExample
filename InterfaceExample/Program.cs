
using InterfaceExample.Models;

var car = new Car(0);

Console.WriteLine("Insert amount of gas to refuel the car:");

var gas = Console.ReadLine();
car.Refuel(Int32.Parse(gas!));

car.Drive();