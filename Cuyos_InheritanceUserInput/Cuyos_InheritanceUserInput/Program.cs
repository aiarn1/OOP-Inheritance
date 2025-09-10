using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_InheritanceUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nSELECT THE TYPE OF SHIRT DO YOU WANT?");
            Console.WriteLine("1. SLEEVELESS");
            Console.WriteLine("2. POLOSHIRT");
            Console.Write("Enter choice (1 or 2): ");
            string choice = Console.ReadLine();

            // Check the user's choice and create the appropriate shirt object
            if (choice == "1")
            {
               
                Console.Write("\nEnter the Brand of the Shirt  : ");
                 string brand = Console.ReadLine();
                Console.Write("Enter the Price of the Shirt  : ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Quantity that you will buy: ");
                string quantity = Console.ReadLine();
                Console.Write("Enter the Color of the Shirt  : ");
                string color = Console.ReadLine();

                // Create a Sleeveless object with the provided details
                Sleeveless sleeveless = new Sleeveless(brand, price, color, quantity);
                sleeveless.MyDerived();
            }
            else if (choice == "2")
            {
               
                Console.Write("\nEnter the Brand of the Shirt  : ");
                string brand = Console.ReadLine();
                Console.Write("Enter the Price of the Shirt  : ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Neck Type of the Shirt: ");
                string neckType = Console.ReadLine();
                Console.Write("Enter the Size of the Shirt   : ");
                string size =Console.ReadLine();

                // Create a PoloShirt object with the provided details
                PoloShirt poloShirt = new PoloShirt(brand, price, neckType, size);
                poloShirt.MyDerived2();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.ReadKey();
        }

    }
}

