using ObserverPattern.Interfaces;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class ComputerShop : ISubject
    {
        private List<IObserver> observers;

        private string _newnotebook;
        public string NewNotebook
        {
            get { return _newnotebook; }
            set { _newnotebook = value; Notify(); }
        }

        public ComputerShop()
        {
            this.observers = new List<IObserver>();
        }

        public void Append(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            observers.ForEach(o =>
            {
                o.Update(this);
            });
        }
    }
}
