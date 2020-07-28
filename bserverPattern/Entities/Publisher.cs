namespace ObserverPattern.Entities
{
    public delegate void Notifier(string message);

    //This is the class which keeps the list of all the subscribers with the help of the delegate instance.
    public class Publisher
    {
        Notifier notifier;
        public void Attach(Notifier notifier)
        {
            this.notifier += notifier;
        }
        public void Remove(Notifier notifier)
        {
            this.notifier -= notifier;
        }
        public void SendMessgae(string message)
        {
            if (this.notifier != null)
                notifier(message);
        }
    }
}
