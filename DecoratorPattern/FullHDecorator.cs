using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{
    // Concrete Decorator
    public class FullHDecorator : NotebookDecorator
    {
        public FullHDecorator(INotebook notebook)
            : base(notebook)
        {
        }
        public override string SearchTypeNotebook()
        {
            string notebook = base.SearchTypeNotebook();
            notebook += "\r\n with full hd screen";
            return notebook;
        }
    }
}