using DecoratorPattern.Interfaces;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            INotebook notebook = new Notebook();
            INotebook withTouchscreen = new TouchscreenDecorator(notebook);
            INotebook withVideoCard = new VideocardDecorator(notebook);
            INotebook withFullHD = new FullHDecorator(notebook);

            Console.WriteLine(notebook.SearchTypeNotebook());
            Console.WriteLine(" ");
            Console.WriteLine(withTouchscreen.SearchTypeNotebook());
            Console.WriteLine(" ");
            Console.WriteLine(withVideoCard.SearchTypeNotebook());
            Console.WriteLine(" ");
            Console.WriteLine(withFullHD.SearchTypeNotebook());
        }
    }
}
