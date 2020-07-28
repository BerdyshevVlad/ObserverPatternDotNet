namespace ObserverPattern.Entities
{
    //Observer is the class which has the instance of the Publisher class and whenever any change is happened in the instance of this class. The publisher is notified which in turn notifies all the subscribers.
    public class Observer
    {
        private Publisher publish;
        public Observer(Publisher publish)
        {
            this.publish = publish;
        }
        public void AddNewArticle(string articleName)
        {
            publish.SendMessgae("New Article Available: " + articleName);
        }
    }
}
