﻿using DesignPatterns.FactoryMethod.Logger.Enums;
using DesignPatterns.FactoryMethod.Logger.Implementations.Factory;
using DesignPatterns.Singleton.CredentialsManager;

namespace DesignPatterns.ConsoleApp
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            #region Factory Pattern
            var consoleLog = LoggerFactory.CreateLogger(ELoggerType.Console);
            consoleLog.Log("Hello! This message should appear on the Console.");

            var fileLog = LoggerFactory.CreateLogger(ELoggerType.File);
            fileLog.Log("Hello! This message should be saved on a file.");
            #endregion

            #region Singleton
            LazyCredentialsManager.Instance.Login("User", "Password");
            var (Username, Password) = LazyCredentialsManager.Instance.GetCredentials();
            consoleLog.Log($"Username: {Username} | Password: {Password}");
            #endregion
        }
    }
}
