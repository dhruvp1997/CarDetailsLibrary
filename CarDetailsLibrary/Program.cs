using System;
using System.Threading.Channels;

namespace CarDetailsLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\tCar Details Library");
            Console.WriteLine("\n\tAn application to see the car details. There are six columns available: company name, model name, " +
                              "\n\tengine, top speed, year of launch, and approx price. One can add new car in this library by " +
                              "\n\tfollowing option 1 from the menu. By following option 2, it will list all the records available " +
                              "\n\tin library. Option 3 will close the application.");
            Console.Write("\n\n\tChoose any one option from the following:");
            Console.Write("\n\n\t1. Add a new car details.");
            Console.Write("\n\t2. To see list of all cars available in library.");
            Console.Write("\n\t3. To exit from the library.");
            Console.Write("\n\n\tChoice:");
            Console.ReadLine();
        }
    }
}
