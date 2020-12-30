using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{
    public class Notebook : INotebook
    {
        public string SearchTypeNotebook()
        {
            var notebook = "This is a simple notebook";
            return notebook;
        }
    }
}
