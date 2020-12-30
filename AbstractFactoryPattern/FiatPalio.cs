using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    public class FiatPalio : IPopularCar
    {
        public string SearchDetailsModel()
        {
            return "Model: Fiat Palio\nYear: 2016\nPotency (cv): 73\n ";
        }
    }
}
