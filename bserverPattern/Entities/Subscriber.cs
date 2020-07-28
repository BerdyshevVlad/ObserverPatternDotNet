using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Entities
{
    //This is the class which is subscribed to the publisher to receive notifications. In our case Person class is the subscriber, where the instances of this class will receive the notifications for the newly published articles.
    public class Subscriber
    {
        private string name;
        public Subscriber(string name)
        {
            this.name = name;
        }
        public void GotArticle(string message)
        {
            Console.WriteLine(string.Format("Hello {0}, {1}", name, message));
        }
    }
}
