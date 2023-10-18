namespace Cars_and_Used_Cars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new Car("Toyota", "Corolla", 2023, 25000);
            Car car3 = new Car("Hyundai", "Elantra", 2023, 26000);
            UsedCar car4 = new UsedCar();
            UsedCar car5 = new UsedCar("Ford", "Mustang", 1969, 86000, 120000);
            UsedCar car6 = new UsedCar("Honda", "Civic", 2012, 14000, 60000);
            Car.Cars.Add(car);
            Car.Cars.Add(car2);
            Car.Cars.Add(car3);
            Car.Cars.Add(car4);
            Car.Cars.Add(car5);
            Car.Cars.Add(car6);

            Console.WriteLine("Welcome to Iring's best buy used cars! Here are my available vehicles:");
            Car.ListCars();
            Console.WriteLine("Please select the index of the car you would like to purchase:");
            int x = Car.inputValidator(Console.ReadLine());
            Console.WriteLine($"Your Purchase: \n   {Car.Cars[x]}");
            Car.Remove(x);
            Car.ListCars();
            Console.WriteLine("Thank you for your purchase! Enjoy your day.");
        }
    }
}