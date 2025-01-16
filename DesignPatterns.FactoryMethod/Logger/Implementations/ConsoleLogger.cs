using DesignPatterns.FactoryMethod.Logger.Contracts;

namespace DesignPatterns.FactoryMethod.Logger.Implementations
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message) =>
            Console.WriteLine(message);
    }
}
