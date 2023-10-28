using DesignPatterns.FactoryMethod.Logger.Contracts;

namespace DesignPatterns.FactoryMethod.Logger.Implementations.ConsoleLogger
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message) =>
            Console.WriteLine(message);
    }
}
