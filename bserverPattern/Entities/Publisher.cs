using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ObserverPattern.Entities
{
    public class Publisher : IPublisher
    {
        //Для удобства в этой переменной храниться состояние Издателя,
        //необходимое всем подписчикам
        public int State { get; set; } = -0;

        //Список подписчиков
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
            System.Console.WriteLine("Subject: Attached an observer");
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            System.Console.WriteLine("Subject: Dettached an observer");
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
        
        public void SomeBusinessLogic()
        {
            System.Console.WriteLine("I am doing some important thisng");

            State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine($"Subject: My state has just changed to {State}");

            this.Notify();
        }
    }
}
