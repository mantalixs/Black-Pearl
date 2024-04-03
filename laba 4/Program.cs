using System;
using System.Collections.Generic;
using Models;
using Services;

class Program
{
    static void Main(string[] args)
    {
        Carrier carrier = new Carrier();

        
        carrier.AddVessel(new TankerShip("Exxon Valdez", 1986, 120, 30000));
        carrier.AddVessel(new TankerShip("Black Pearl", 2003, 80, 40000));
        carrier.AddVessel(new TankerShip("Titanic", 1912, 200, 20000));
        carrier.AddVessel(new TankerShip("Nautilus", 1870, 150, 35000));

        
        carrier.AddVessel(new CargoShip("Millennium Falcon", 1977, 50, 5000));
        carrier.AddVessel(new CargoShip("Black Pearl", 2003, 80, 6000));
        carrier.AddVessel(new CargoShip("Death Star", 1977, 150, 7000));
        carrier.AddVessel(new CargoShip("USS Enterprise", 1966, 100, 8000));
        carrier.AddVessel(new CargoShip("Serenity", 2002, 90, 9000));
        carrier.AddVessel(new CargoShip("Delorean", 1985, 70, 10000));

        Console.WriteLine($"Total cargo capacity of the carrier: {carrier.CalculateTotalCargoCapacity()} tons");
        Console.WriteLine($"Total fuel consumption of the carrier: {carrier.CalculateTotalFuelConsumption()} liters per hour");

        carrier.SortVesselsByFuelConsumption();

        List<Vessel> vesselsInRange = carrier.FindVesselsByYearRange(2000, 2010);
        Console.WriteLine("Vessels within the specified year range:");
        foreach (var vessel in vesselsInRange)
        {
            Console.WriteLine($"Name: {vessel.Name}, Year: {vessel.Year}");
        }
    }
}