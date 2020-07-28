using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Entities
{
    public class ConcreteObserverB : Interfaces.IObserver
    {
        public void Update(IPublisher subject)
        {
            if ((subject as Publisher).State == 0 || (subject as Publisher).State>=2)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event");
            }
        }
    }
}
