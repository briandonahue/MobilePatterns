using System.Collections.Generic;
using TinyIoC;

namespace MobilePatterns.Core.Infrastructure.IoC
{
    public class TinyIoCResolver: IDependencyResolver
    {
        TinyIoCContainer container;

        public TinyIoCResolver()
        {
            container = TinyIoCContainer.Current;
        }

        public IEnumerable<T> ResolveAll<T>() where T : class
        {
            yield return container.Resolve<T>();
        }
    }
}