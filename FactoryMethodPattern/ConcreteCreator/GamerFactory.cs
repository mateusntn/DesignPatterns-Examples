using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.Creator;
using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.ConcreteCreator
{
    public class GamerFactory : MouseFactory
    {
        private int _dpi;
        private string _connection;
        public GamerFactory(int dpi, string connection)
        {
            this._dpi = dpi;
            this._connection = connection;
        }
        public override Mouse SearchMouse()
        {
            return new GamerMouse(_dpi, _connection);
        }
    }
}
