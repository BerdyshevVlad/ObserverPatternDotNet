using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface IPublisher
    {
        //Присоединяет наблюдателя к издателю
        void Attach(IObserver observer);

        //Отсоединяет наблюдателя от издателя
        void Detach(IObserver observer);

        //Уведомляет всех наблюдателей о событии
        void Notify();
    }
}
