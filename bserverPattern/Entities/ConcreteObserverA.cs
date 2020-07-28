using System;
using System.Collections.Generic;
using System.Text;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Entities
{
    public class ConcreteObserverA : Interfaces.IObserver
    {
        public void Update(IPublisher subject)
        {
            if((subject as Publisher).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event");
            }
        }
    }
}
