using System.Collections.Generic;
using Models;
using System.Linq;


namespace Services
{ public class Carrier
    {
        public List<Vessel> Vessels { get; set; }
        
        public Carrier()
        {
            Vessels = new List<Vessel>();
        }
        
        public void AddVessel(Vessel vessel)
        {
            Vessels.Add(vessel);
        }
        
        public double CalculateTotalCargoCapacity()
        {
            return Vessels.Sum(vessel => (vessel as TankerShip)?.CargoCapacity ?? 0 + (vessel as CargoShip)?.CargoCapacity ?? 0);
        }
        public double CalculateTotalFuelConsumption()
        {
            return Vessels.Sum(vessel => vessel.FuelConsumption);
        }
        public void SortVesselsByFuelConsumption()
        {
            Vessels.Sort((x, y) => x.FuelConsumption.CompareTo(y.FuelConsumption));
        }
        
        public List<Vessel> FindVesselsByYearRange(int startYear, int endYear)
        {
            return Vessels.Where(vessel => vessel.Year >= startYear && vessel.Year <= endYear).ToList();
        }
    }
}