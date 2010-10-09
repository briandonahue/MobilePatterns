namespace MobilePatterns.Core.Infrastructure.Events
{
    public interface IEventAggregator
    {
        void Publish<T>(T eventMessage);
        void Subscribe(object subscriber);
        void Unsubscribe(object subscriber);
    }
}