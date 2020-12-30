using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class CarClient
    {
        ILuxuryCar luxuryCar;
        IPopularCar popularCar;

        public CarClient(ICar carfactory)
        {
            luxuryCar = carfactory.SearchLuxuryCar();
            popularCar = carfactory.SearchPopularCar();
        }

        public string SearchLuxuryCarDetailsModel()
        {
            return luxuryCar.SearchDetailsModel();
        }

        public string SearchPopularCarDetailsModel()
        {
            return popularCar.SearchDetailsModel();
        }
    }
}
