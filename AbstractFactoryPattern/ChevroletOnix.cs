using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    public class ChevroletOnix : ILuxuryCar
    {
        public string SearchDetailsModel()
        {
            return "Model: Chevrolet Onix\nYear: 2020\nPotency (cv): 116\n ";
        }
    }
}
