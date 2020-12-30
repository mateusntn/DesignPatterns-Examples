using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{
    // Concrete Decorator
    public class VideocardDecorator : NotebookDecorator
    {
        public VideocardDecorator(INotebook notebook)
            : base(notebook)
        {
        }
        public override string SearchTypeNotebook()
        {
            string notebook = base.SearchTypeNotebook();
            notebook += "\r\n with dedicated video card";
            return notebook;
        }
    }
}