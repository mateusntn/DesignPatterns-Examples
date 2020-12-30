namespace FactoryMethodPattern.Product
{
    public abstract class Mouse
    {
        public abstract string MouseType { get; }
        public abstract int Dpi { get; set; }
        public abstract string Connection { get; set; }
    }
}
