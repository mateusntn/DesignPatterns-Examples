using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{
    //Base Decorator
    public class NotebookDecorator : INotebook
    {
        private readonly INotebook _notebook;

        public NotebookDecorator(INotebook notebook)
        {
            this._notebook = notebook;
        }
        public virtual string SearchTypeNotebook()
        {
            var notebook = _notebook.SearchTypeNotebook();
            return notebook;
        }
    }
}
