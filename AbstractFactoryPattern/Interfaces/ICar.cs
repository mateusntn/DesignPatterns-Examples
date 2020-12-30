namespace AbstractFactoryPattern.Interfaces
{
    public interface ICar
    {
        ILuxuryCar SearchLuxuryCar();
        IPopularCar SearchPopularCar();
    }
}
