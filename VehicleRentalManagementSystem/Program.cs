using System.Diagnostics;

public class Vehicle
{
    // Properties
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }
    public decimal RentalPrice { get; set; }
      
    // Constructor
    public Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
        RentalPrice = rentalPrice;
    }

    // Method to display vehicle details
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"_______________________________________ \n");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Rental Price: {RentalPrice}");

    }
}
public class Car : Vehicle
{
    // Additional properties specific to cars
    public int Seats { get; set; }
    public string EngineType { get; set; }
    public string Transmission { get; set; }
    public bool Convertible { get; set; }

    // Constructor
    public Car(string model, string manufacturer, int year, decimal rentalPrice, int seats, string engineType, string transmission, bool convertible)
        : base(model, manufacturer, year, rentalPrice)
    {
        Seats = seats;
        EngineType = engineType;
        Transmission = transmission;
        Convertible = convertible;
    }

    // Override DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Seats: {Seats}");
        Console.WriteLine($"Engine Type: {EngineType}");
        Console.WriteLine($"Transmission: {Transmission}");
        Console.WriteLine($"Convertible: {Convertible} \n");

    }
}
public class Truck : Vehicle
{
    // Additional properties specific to trucks
    public double Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWheelDrive { get; set; }

    // Constructor
    public Truck(string model, string manufacturer, int year, decimal rentalPrice, double capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year, rentalPrice)
    {
        Capacity = capacity;
        TruckType = truckType;
        FourWheelDrive = fourWheelDrive;
    }

    // Override DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Capacity: {Capacity}");
        Console.WriteLine($"Truck Type: {TruckType}");
        Console.WriteLine($"Four Wheel Drive: {FourWheelDrive} \n");

    }
}
public class Motorcycle : Vehicle
{
    // Additional properties specific to motorcycles
    public int EngineCapacity { get; set; }
    public string FuelType { get; set; }
    public bool HasFairing { get; set; }

    // Constructor
    public Motorcycle(string model, string manufacturer, int year, decimal rentalPrice, int engineCapacity, string fuelType, bool hasFairing)
        : base(model, manufacturer, year, rentalPrice)
    {
        EngineCapacity = engineCapacity;
        FuelType = fuelType;
        HasFairing = hasFairing;
    }

    // Override DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Engine Capacity: {EngineCapacity}");
        Console.WriteLine($"Fuel Type: {FuelType}");
        Console.WriteLine($"Has Fairing: {HasFairing}\n");

    }
}
public class RentalAgency
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

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each vehicle type
        Car car = new Car("Model S", "Tesla", 2020, 150m, 5, "Electric", "Automatic", false);
        Truck truck = new Truck("F-150", "Ford", 2019, 200m, 1000, "Pickup", true);
        Motorcycle motorcycle = new Motorcycle("Ninja", "Kawasaki", 2021, 100m, 650, "Petrol", true);

        // Create an instance of RentalAgency
        RentalAgency rentalAgency = new RentalAgency();

        // Add vehicles to the fleet
        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        // Rent out a car for 5 days
        rentalAgency.RentVehicle(car, 5);

        // Display fleet details
        rentalAgency.DisplayFleetDetails();

        // Display total revenue
        Console.WriteLine($"Total Revenue: {rentalAgency.TotalRevenue}\n");
    }
}
