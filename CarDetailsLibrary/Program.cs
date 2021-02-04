using System;
using System.Threading.Channels;

namespace CarDetailsLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n\n\tCar Details Library");
            Console.Write("\n\n\tAn application to see the car details. There are six columns available: company name, model name, " +
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
                    Console.Write("\n\tModel name: ");
                    Console.Write("\n\tEngine: ");
                    Console.Write("\n\tTop speed: ");
                    Console.Write("\n\tYear of launch: ");
                    Console.Write("\n\tApprox price: ");
                }
                    break;
                case 2:
                {
                    Console.Clear();
                    Console.Write("\n\n\n\tCar details available in library:-");
                    Console.Write("\n\n\tCompany_Name\tModel_Name\tEngine\t\tTop_Speed\tYear_of_launch\t\tApprox_price");
                    Console.Write("\n\t----------------------------------------------------------------------------------------------------");
                }
                    break;
                case 3:
                {
                    break;
                }
                default:
                    { }
                    break;
            }

            Console.ReadLine();
        }
    }
}
