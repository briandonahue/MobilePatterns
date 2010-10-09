namespace MobilePatterns.Core.Infrastructure.Events
{
    public interface IHandle<T>
    {
        void Handle(T eventMessage);
    }
}