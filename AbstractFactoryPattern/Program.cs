using AbstractFactoryPattern.ConcretesFactory;
using AbstractFactoryPattern.Interfaces;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar fiatCar = new Fiat();
            CarClient fiatClient = new CarClient(fiatCar);

            Console.WriteLine("----------- FIAT -----------");
            Console.WriteLine(fiatClient.SearchLuxuryCarDetailsModel());
            Console.WriteLine(fiatClient.SearchPopularCarDetailsModel());

            ICar chevroletCar = new Chevrolet();
            CarClient chevroletClient = new CarClient(chevroletCar);

            Console.WriteLine("----------- CHEVROLET -----------");
            Console.WriteLine(chevroletClient.SearchLuxuryCarDetailsModel());
            Console.WriteLine(chevroletClient.SearchPopularCarDetailsModel());
        }
    }
}
