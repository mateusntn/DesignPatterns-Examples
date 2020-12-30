using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    public class ChevroletCelta : IPopularCar
    {
        public string SearchDetailsModel()
        {
            return "Model: Chevrolet Celta\nYear: 2016\nPotency (cv): 77\n ";
        }
    }
}
