
using ConsoleApp2;

Vehicle vehicle;

Console.WriteLine("Please type the vehicle you would like to create:");
var input = Console.ReadLine();

if (input == "car")
{
    vehicle = new Car();
}
else if (input == "truck")
{
    vehicle = new Truck();
}
else
{
    vehicle = new Car();
}

Console.WriteLine(vehicle.GetType().Name);