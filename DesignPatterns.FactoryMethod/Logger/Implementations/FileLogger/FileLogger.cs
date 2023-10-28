using DesignPatterns.FactoryMethod.Logger.Contracts;

namespace DesignPatterns.FactoryMethod.Logger.Implementations.FileLogger
{
    public class FileLogger : ILogger
    {
        public void Log(string message) =>
            File.AppendAllLines(Path.Join(AppContext.BaseDirectory, "Logs"), new string[] { message });
    }
}
