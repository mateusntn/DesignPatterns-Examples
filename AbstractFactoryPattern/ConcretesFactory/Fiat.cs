using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.ConcretesFactory
{
    public class Fiat : ICar
    {
        public ILuxuryCar SearchLuxuryCar()
        {
            return new FiatArgo();
        }

        public IPopularCar SearchPopularCar()
        {
            return new FiatPalio();
        }
    }
}
