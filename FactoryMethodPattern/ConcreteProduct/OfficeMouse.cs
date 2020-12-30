using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class OfficeMouse : Mouse
    {
        private readonly string _mouseType;
        private int _dpi;
        private string _connection;
        public OfficeMouse(int dpi, string connection)
        {
            this._mouseType = "Office";
            this._dpi = dpi;
            this._connection = connection;
        }
        public override string MouseType
        {
            get { return _mouseType; }
        }

        public override int Dpi
        {
            get { return _dpi; }
            set { _dpi = value; }
        }
        public override string Connection
        {
            get { return _connection; }
            set { _connection = value; }
        }
    }
}
