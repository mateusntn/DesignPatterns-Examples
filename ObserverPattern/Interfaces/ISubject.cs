namespace ObserverPattern.Interfaces
{
    public interface ISubject
    {
        void Append(IObserver observer);
        void Notify();
    }
}
