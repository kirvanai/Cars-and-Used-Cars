using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Used_Cars
{
    public class UsedCar : Car
    {

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public double Mileage { get; set; }

        public UsedCar()
        {
            Make = "Ford";
            Model = "Focus";
            Year = 2015;
            Price = 12000;
            Mileage = 50000;
        }

        public UsedCar(string make, string model, int year, decimal price, double mileage)
        {
            Make =make;
            Model = model;
            Year = year;
            Price = price;
            Mileage = mileage;
        }

        public override string ToString()
        {
            string output = "Make: " + Make + "\n";
            output += "  Model: " + Model + "\n";
            output += "   Year: " + Year + "\n";
            output += "  Price: $" + Price +"\n";
            output += "Mileage: " + Mileage;
            return output;
        }
    }
}
