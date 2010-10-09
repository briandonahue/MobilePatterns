using System.Collections.Generic;

namespace MobilePatterns.Core.Infrastructure.IoC
{
    public interface IDependencyResolver
    {
        IEnumerable<T> ResolveAll<T>() where T: class;
    }
}