using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace CarDetailsLibrary
{
    class Program
    {
        private class Car
        {
            public Car(string companyName, string modelName, string engine, int topSpeed, DateTime yearOfLaunch,
                double approxPrice)
            {
                CompanyName = companyName;
                ModelName = modelName;
                Engine = engine;
                TopSpeed = topSpeed;
                YearOfLaunch = yearOfLaunch;
                ApproxPrice = approxPrice;
            }
            public string CompanyName { get; set; }
            public string ModelName { get; set; }
            public string Engine { get; set; }
            public int TopSpeed { get; set; }
            public DateTime YearOfLaunch { get; set; }
            public Double ApproxPrice { get; set; }

        }
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            while (true)
            {
                Console.Clear();
                Console.Write("\n\n\n\tCar Details Library");
                Console.Write(
                    "\n\n\tAn application to see the car details. There are six columns available: company name, model name, " +
                    "\n\tengine, top speed, year of launch, and approx price. One can add new car in this library by " +
                    "\n\tfollowing option 1 from the menu. By following option 2, it will list all the records available " +
                    "\n\tin library. Option 3 will close the application.");
                //I have made this program a menu type program.
                // There are three options available to select.
                Console.Write("\n\n\tChoose any one option from the following:");
                Console.Write("\n\n\t1. Add a new car details.");
                Console.Write("\n\t2. To see list of all car details available in library.");
                Console.Write("\n\t3. To exit from the library.");
                Console.Write("\n\n\tChoice:");
                // Stored user input into menu variable to perform further task.
                int menu = Convert.ToInt32(Console.ReadLine());
                // Used Switch function to perform particular program.
                switch (menu)
                {
                    case 1:
                    {
                        Console.Clear();
                        Console.Write("\n\n\n\tAdd a new car details:-");
                        Console.Write("\n\n\tCompany name: ");
                        var companyName = Console.ReadLine();
                        Console.Write("\n\tModel name: ");
                        var modelName = Console.ReadLine();
                        Console.Write("\n\tEngine: ");
                        var engine = Console.ReadLine();
                        Console.Write("\n\tTop speed: ");
                        var topSpeed = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n\tYear of launch: ");
                        var yearOfLaunch = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("\n\tApprox price: ");
                        var approxPrice = Convert.ToDouble(Console.ReadLine());
                        cars.Add(new Car(companyName, modelName, engine, topSpeed, yearOfLaunch, approxPrice));
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadLine();
                    }
                        break;
                    case 2:
                    {
                        Console.Clear();
                        Console.Write("\n\n\n\tCar details available in library:-");
                        Console.Write(
                            "\n\n\tCompany_Name\tModel_Name\tEngine\t\tTop_Speed\tYear_of_launch\t\tApprox_price");
                        Console.Write(
                            "\n\t----------------------------------------------------------------------------------------------------");
                        Console.ReadLine();
                    }
                        break;
                    case 3:
                    {
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("You just entered a bad Input!!! Type any number between 1 to 3");
                    }
                        break;
                }
            }
        }
    }
}
