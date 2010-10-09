namespace MobilePatterns.Core.Infrastructure.Commands
{
    public interface ICommand<TCommandMessage>
    {
        void Execute(TCommandMessage commandMessage);

    }
}