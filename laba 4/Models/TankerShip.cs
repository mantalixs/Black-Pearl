
namespace Models
{
    public class TankerShip : Vessel
    {
        public double CargoCapacity { get; set; }
        
        public TankerShip(string name, int year, double fuelConsumption, double cargoCapacity)
            : base(name, year, fuelConsumption)
        {
            CargoCapacity = cargoCapacity;
        }
    }
}