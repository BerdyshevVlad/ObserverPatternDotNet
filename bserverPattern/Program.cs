using ObserverPattern.Entities;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Publisher();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();

            Console.ReadLine();
        }
    }
}
