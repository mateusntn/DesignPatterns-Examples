using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern
{
    public class NewClient : IObserver
    {
        public string ClientName { get; set; }
        public NewClient (string ClientName)
        {
            this.ClientName = ClientName;
        }
        public void Update(ISubject subject)
        {
            if (subject is ComputerShop computerShop)
            {
                Console.WriteLine($"Hi {ClientName} the new notebook arrived at our store: {computerShop.NewNotebook}");
                Console.WriteLine();
            }
        }
    }
}
