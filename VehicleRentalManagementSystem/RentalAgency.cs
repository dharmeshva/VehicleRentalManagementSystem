using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagementSystem
{
    internal class RentalAgency
    {

        // Array to store instances of vehicles
        private List<Vehicle> Fleet = new List<Vehicle>();
        public decimal TotalRevenue { get; private set; }

        // Method to add vehicles to the fleet
        public void AddVehicle(Vehicle vehicle)
        {
            Fleet.Add(vehicle);
        }

        // Method to remove vehicles from the fleet
        public void RemoveVehicle(Vehicle vehicle)
        {
            Fleet.Remove(vehicle);
        }

        // Method to rent vehicles
        public void RentVehicle(Vehicle vehicle, int days)
        {
            TotalRevenue += vehicle.RentalPrice * days;
        }

        // Method to display fleet details
        public void DisplayFleetDetails()
        {
            foreach (var vehicle in Fleet)
            {
                vehicle.DisplayDetails();
            }
        }
    }
}
