using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{
    // Concrete Decorator
    public class TouchscreenDecorator : NotebookDecorator
    {
        public TouchscreenDecorator(INotebook notebook)
            : base(notebook)
        {
        }
        public override string SearchTypeNotebook()
        {
            string notebook = base.SearchTypeNotebook();
            notebook += "\r\n with touchscreen";
            return notebook;
        }
    }
}
