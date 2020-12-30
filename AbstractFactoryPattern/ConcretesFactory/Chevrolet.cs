using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.ConcretesFactory
{
    public class Chevrolet : ICar
    {
        public ILuxuryCar SearchLuxuryCar()
        {
            return new ChevroletOnix();
        }

        public IPopularCar SearchPopularCar()
        {
            return new ChevroletCelta();
        }
    }
}
