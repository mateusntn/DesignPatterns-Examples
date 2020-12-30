using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.ConcreteProduct
{
    public class GamerMouse : Mouse
    {
        private readonly string _mouseType;
        private int _dpi;
        private string _connection;
        public GamerMouse (int dpi, string connection)
        {
            this._mouseType = "Gamer";
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
