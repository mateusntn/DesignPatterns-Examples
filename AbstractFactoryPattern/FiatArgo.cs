using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    public class FiatArgo : ILuxuryCar
    {
        public string SearchDetailsModel()
        {
            return "Model: Fiat Argo\nYear: 2020\nPotency (cv): 130\n ";
        }
    }
}
