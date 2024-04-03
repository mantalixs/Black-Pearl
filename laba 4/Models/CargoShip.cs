
namespace Models
{
    public class CargoShip : Vessel
    {
        public double CargoCapacity { get; set; }

        
        public CargoShip(string name, int year, double fuelConsumption, double cargoCapacity)
            : base(name, year, fuelConsumption)
        {
            CargoCapacity = cargoCapacity;
        }
    }
}