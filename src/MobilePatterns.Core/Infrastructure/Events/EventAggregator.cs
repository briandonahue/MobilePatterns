using System;
using System.Collections.Generic;
using System.Linq;

namespace MobilePatterns.Core.Infrastructure.Events
{
    public class EventAggregator : IEventAggregator
    {
        IList<object> subscribers;

        public EventAggregator()
        {
            subscribers = new List<Object>();

        }

        public void Publish<T>(T eventMessage)
        {
            var listeners = subscribers.Where(s => s as IHandle<T> != null).Cast<IHandle<T>>();

            foreach (var listener in listeners)
            {
                var action = new Action(() => listener.Handle(eventMessage));
                action.BeginInvoke(null, null);
            }
        }

        public void Subscribe(object subscriber)
        {
            if(subscriber != null)
                subscribers.Add(subscriber);
        }

        public void Unsubscribe(object subscriber)
        {
            if (subscribers.Contains(subscriber))
                subscribers.Remove(subscriber);
           
        }
    }
}