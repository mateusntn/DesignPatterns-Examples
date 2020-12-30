using FactoryMethodPattern.ConcreteCreator;
using FactoryMethodPattern.Creator;
using FactoryMethodPattern.Product;
using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MouseFactory mouseFactory = null;
            Console.WriteLine("Enter the number corresponding to the type of mouse you want:\n 1 - Gamer\n 2 - Office");
            string typeMouseEnter = Console.ReadLine();

            switch(typeMouseEnter)
            {
                case "1":
                    mouseFactory = new GamerFactory(8000, "USB");
                    break;
                case "2":
                    mouseFactory = new OfficeFactory(1000, "Wireless");
                    break;
                default:
                    Console.WriteLine("Enter a valid number.");
                    break;
            }
            Mouse mouse = mouseFactory.SearchMouse();
            Console.WriteLine("\n These are the details of your mouse: ");
            Console.WriteLine($"Mouse Type: {mouse.MouseType}\nDPI: {mouse.Dpi}\nConnection: {mouse.Connection} ");

        }
    }
}
