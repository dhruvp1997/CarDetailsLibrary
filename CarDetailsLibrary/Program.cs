using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Channels;

namespace CarDetailsLibrary
{
    class Program
    {
       

        static void Main(string[] args)
        {
            try
            {
                var cars = new List<CarLaunchAndPrice>();
                var c = new CarEngine();
                int recurrence = 1;
                while (recurrence == 1)
                {
                    var IO = new InputOutput();
                    IO.Intro();
                    IO.Menu();
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
                            cars.Add(new CarLaunchAndPrice(companyName, modelName, engine, topSpeed, yearOfLaunch, approxPrice));
                            c.Count();
                            Console.Write("\n\tAvailable entries in database is: "+c.Counts);
                            Console.WriteLine("\n\n\tPress any key to continue..."); 
                            Console.ReadLine();
                        }
                            break;
                        case 2:
                        {
                            Console.Clear();
                            Console.Write("\n\n\n\tCar details available in library:-");
                            // It will show all the details available in objects.
                            if (c.Counts > 0)
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
