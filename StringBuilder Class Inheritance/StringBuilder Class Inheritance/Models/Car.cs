namespace StringBuilder_Class_Inheritance.Models
{
    public class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        public Car(string brand, string model, int fuelCapacity, double fuelFor1Km, int currentFuel,int year,string color):base(color , year)
        {
            Brand = brand;
            Model = model;
            FuelCapacity = fuelCapacity;
            FuelFor1Km = fuelFor1Km;
            CurrentFuel = currentFuel;
            Year = year;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}, " +
                $"Model: {Model}, " +
                $"FuelCapacity: {FuelCapacity}, " +
                $"FuelFor1Km: {FuelFor1Km}, " +
                $"CurrentFuel: {CurrentFuel}, " +
                $"Year: {Year}");
        }
        public void Drive(int distance)
        {
            if (distance * FuelFor1Km <= CurrentFuel)
                Console.WriteLine("Remaining fuel after driving: " + (CurrentFuel - distance * FuelFor1Km));
            else
                Console.WriteLine("Not enough fuel");           
        }
    }
}
