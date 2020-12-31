using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerShop computerShop = new ComputerShop();
            NewClient client1 = new NewClient("João");
            computerShop.Append(client1);

            NewClient client2 = new NewClient("Maria");
            computerShop.Append(client2);

            computerShop.NewNotebook = "Acer Aspire 5";
            computerShop.NewNotebook = "Samsung Book x50";
            computerShop.NewNotebook = "Lenovo Ideaped S145";
            computerShop.NewNotebook = "Acer Nitro 5";

            Console.ReadLine();
        }
    }
}
