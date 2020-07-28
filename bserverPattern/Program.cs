using ObserverPattern.Entities;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber person1 = new Subscriber("Michale");
            publisher.Attach(person1.GotArticle);
            Subscriber person2 = new Subscriber("Jordon");
            publisher.Attach(person2.GotArticle);
            Observer observer = new Observer(publisher);
            observer.AddNewArticle("Delegates in C#");
            publisher.Remove(person2.GotArticle);
            observer.AddNewArticle("Observer pattern");

            Console.ReadLine();
        }
    }
}
