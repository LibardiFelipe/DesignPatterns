using DesignPatterns.FactoryMethod.Logger.Contracts;

namespace DesignPatterns.FactoryMethod.Logger.Implementations.ConsoleLogger
{
    public class ConsoleLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger() =>
            new ConsoleLogger();
    }
}
