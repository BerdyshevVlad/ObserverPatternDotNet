using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface IObserver
    {
        //Получает обновление от издателя
        void Update(IPublisher subject);
    }
}
