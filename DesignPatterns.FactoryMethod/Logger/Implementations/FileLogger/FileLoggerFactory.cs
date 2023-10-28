using DesignPatterns.FactoryMethod.Logger.Contracts;

namespace DesignPatterns.FactoryMethod.Logger.Implementations.FileLogger
{
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger() =>
            new FileLogger();
    }
}
