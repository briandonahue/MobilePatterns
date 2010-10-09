using System;
using MobilePatterns.Core.Infrastructure.Commands;
using MobilePatterns.Core.Infrastructure.Events;
using TinyIoC;

namespace MobilePatterns.Core.Infrastructure
{
    public class AppController : IAppController
    {
        readonly IEventAggregator eventAggregator;

        public AppController(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }


        public void RunCommandAsync<T>(T commandMessage)
        {
            var command = TinyIoCContainer.Current.Resolve<ICommand<T>>();
            Action commandAction = () => command.Execute(commandMessage);
            Console.WriteLine(command.GetType()+ " was fired.");
            commandAction.BeginInvoke(null, null);
        }

        public void Raise<T>(T eventMessage)
        {
            eventAggregator.Publish(eventMessage);
            Console.WriteLine(eventMessage.GetType() + " was raised.");
        }

        public void SubscribeToEvents(object subscriber)
        {
            eventAggregator.Subscribe(subscriber);
        }

        public void UnsubscribeFromEvents(object subscriber)
        {
            eventAggregator.Unsubscribe(subscriber);
        }

    }
}