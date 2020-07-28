using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Entities
{
    // Конкретный издатель.
    class ConcreteSubject : Subject
    {
        public override string State { get; set; }
        public override void Notify()
        {
            observers.Invoke(State);
        }
    }
}
