using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.Creator;
using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.ConcreteCreator
{
    public class OfficeFactory : MouseFactory
    {
        private int _dpi;
        private string _connection;
        public OfficeFactory(int dpi, string connection)
        {
            this._dpi = dpi;
            this._connection = connection;
        }
        public override Mouse SearchMouse()
        {
            return new OfficeMouse(_dpi, _connection);
        }
    }
}
