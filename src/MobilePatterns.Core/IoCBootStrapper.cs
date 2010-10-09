using System;
using MobilePatterns.Core.Infrastructure;
using TinyIoC;

namespace MobilePatterns.Core
{
    public class IoCBootStrapper
    {
        public static void Initialize()
        {
            TinyIoCContainer container = TinyIoCContainer.Current;
            container.AutoRegister(typeof (AppController).Assembly);
        }
    }
}