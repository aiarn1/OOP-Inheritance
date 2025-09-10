using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_InheritanceUserInput
{
    class Shirt
    {
        //Fields

        public string brand;
        public int price;

        // Parameterized Constructor
        public Shirt(string aname, int aprice)
        {
            brand = aname;
            price = aprice;
        }
        // Methods to Display
        public void MyShirt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tShirt Details:");
            Console.WriteLine("\n\tBrand    : " + brand);
            Console.WriteLine("\tPrice    : " + price);

            
        }
    }

    class Sleeveless : Shirt
    {
        // Fields
        public string color;
        public string quantity;

        // Parameterized Constructor
        public Sleeveless(string abrand, int aprice, string acolor, string aquantity) : base(abrand, aprice)
        {
            color = acolor;
            quantity = aquantity;
        }

        // Methods to Display
        public void MyDerived()
        {
            MyShirt();
            Console.WriteLine("\tQuantity : " + quantity);           
            Console.WriteLine("\tColor    : " + color);
           
        }

    }
    // Derived Class
    class PoloShirt : Shirt
    {
        // Fields
        public string neckType;
        public string size;

        // Parameterized Constructor
        public PoloShirt(string abrand, int aprice, string aneckType, string asize) : base(abrand, aprice)
        {
            neckType = aneckType;
            size = asize;
        }

        // Methods to Display 
        public void MyDerived2()
        {
            MyShirt();
            Console.WriteLine("\tNeck Type: " + neckType);
            Console.WriteLine("\tSize     : " + size);
            

        }
    }
}
