using System;
using System.Collections.Generic;
using System.Net.Mime;
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
            try
            {
                var cars = new List<Car>();
                int recurrence = 1;
                while (recurrence == 1)
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
                            // This case will store the data into objects.
                            Console.Clear();
                            Console.Write("\n\n\n\tAdd a new car details:-");
                            Console.Write("\n\n\tCompany name: ");
                            var companyName = Console.ReadLine();
                            Console.Write("\tModel name: ");
                            var modelName = Console.ReadLine();
                            Console.Write("\tEngine: ");
                            var engine = Console.ReadLine();
                            Console.Write("\tTop speed: ");
                            var topSpeed = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\tYear of launch: ");
                            var yearOfLaunch = Convert.ToDateTime(Console.ReadLine());
                            Console.Write("\tApprox price: ");
                            var approxPrice = Convert.ToDouble(Console.ReadLine());
                            cars.Add(new Car(companyName, modelName, engine, topSpeed, yearOfLaunch, approxPrice));
                            Console.WriteLine("\n\n\tPress any key to continue...");
                            Console.ReadLine();
                        }
                            break;
                        case 2:
                        {
                            Console.Clear();
                            Console.Write("\n\n\n\tCar details available in library:-");
                            // It will show all the details available in objects.
                            if (cars.Count > 0)
                            {
                                foreach (var car in cars)
                                {
                                    Console.Write("\n\n\t------------------------------------------------------------------------------------");
                                    Console.Write($"\n\n\tCompany Name: {car.CompanyName}");
                                    Console.Write($"\n\tModel Name: {car.ModelName}");
                                    Console.Write($"\n\tEngine: {car.Engine}");
                                    Console.Write($"\n\tTop Speed: {car.TopSpeed}");
                                    Console.Write($"\n\tYear of Launch: {car.YearOfLaunch}");
                                    Console.Write($"\n\tApprox Price: {car.ApproxPrice}");
                                }
                            }
                            else
                            {
                                Console.Write("\n\tSorry!! you did not enter any car yet.");
                            }

                            Console.Write("\n\n\n\tPress any key to continue...");
                            Console.ReadLine();
                        }
                            break;
                        case 3:
                        {
                            //This case will exit the application.
                            recurrence = 0;
                        }
                            break;
                        default:
                        {
                            Console.WriteLine("You just entered a bad Input!!! Type any number between 1 to 3");
                        }
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("You just made a mistake. Your error is "+e);
            }
        }
    }
}
