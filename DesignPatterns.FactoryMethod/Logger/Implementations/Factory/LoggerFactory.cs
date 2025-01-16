using DesignPatterns.FactoryMethod.Logger.Contracts;
using DesignPatterns.FactoryMethod.Logger.Enums;

namespace DesignPatterns.FactoryMethod.Logger.Implementations.Factory
{
    public static class LoggerFactory
    {
        public static ILogger CreateLogger(ELoggerType type)
        {
            return type switch
            {
                ELoggerType.Console => new ConsoleLogger(),
                ELoggerType.File => new FileLogger(),
                _ => throw new NotSupportedException(),
            };
        }
    }
}
