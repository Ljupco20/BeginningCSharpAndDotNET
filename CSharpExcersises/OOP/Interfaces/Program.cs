using Interfaces;

Car car = new Car();

car.Driving();

bool refuel = car.Refuel(50);

if (refuel) 
{
    Console.WriteLine("The car was refueld");
}

car.Driving();