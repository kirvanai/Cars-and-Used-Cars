using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Used_Cars
{
    public class Car
    {
        public string Make {  get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public static List<Car> Cars { get; set; } = new List<Car>();

        public Car() 
        {
            Make = "Ford";
            Model = "Focus";
            Year = 2023;
            Price = 20000;
        }

        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public override string ToString()
        {
            string output = "Make: " + Make + "\n";
            output += "  Model: " + Model + "\n";
            output += "   Year: " + Year + "\n";
            output += "  Price: $" + Price;

            return output;
        }

        public static void ListCars()
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"{i}) {Cars[i]}");
            }
        }

        public static void Remove(int i)
        {
            Cars.RemoveAt(i);
        }

        public static int inputValidator(string input)
        {
            try
            {
                int selection = int.Parse(input);
                if (selection > Cars.Count-1)
                {
                    Console.WriteLine($"Please select index 0 - {Cars.Count-1}.");
                    input = Console.ReadLine();
                    return inputValidator(input);
                }
                return selection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Please select index 0 - {Cars.Count-1}.");
                input = Console.ReadLine();
                return inputValidator(input);
            }
        }
    }
}
