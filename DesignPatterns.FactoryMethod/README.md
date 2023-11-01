# Factory Method Pattern

## Overview
This repository demonstrates the Factory Method design pattern using a simple logging mechanism. The Factory Method pattern is a creational design pattern that provides an interface for creating objects but allows subclasses to alter the type of objects that will be created.

In this example, we have two main interfaces:
* **ILogger**: Defines the logging operation.
* **ILoggerFactory**: Defines the factory method to create ILogger instances.

Two concrete implementations are provided:
* **FileLogger**: Writes logs to a file.
* **ConsoleLogger**: Writes logs to the console.

## Usage
To use the logger, you'll need to instantiate a logger factory and then create a logger.

```
ILoggerFactory loggerFactory = new FileLoggerFactory();
ILogger logger = loggerFactory.CreateLogger();
logger.Log("This should be logged to a file.");
```
Or
```
ILoggerFactory loggerFactory = new ConsoleLoggerFactory();
ILogger logger = loggerFactory.CreateLogger();
logger.Log("This should be logged in the console.");
```