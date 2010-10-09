namespace MobilePatterns.Core.Infrastructure
{
    public interface IAppController
    {
        void RunCommandAsync<T>(T commandMessage);
        void Raise<T>(T eventMessage);
        void SubscribeToEvents(object subscriber);
        void UnsubscribeFromEvents(object subscriber);
    }
}