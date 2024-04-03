
namespace Models
{
    public class Vessel
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public double FuelConsumption { get; set; }
        public Vessel(string name, int year, double fuelConsumption)
        {
            Name = name;
            Year = year;
            FuelConsumption = fuelConsumption;
        }
    }
}