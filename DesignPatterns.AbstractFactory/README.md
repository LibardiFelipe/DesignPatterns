# Abstract Factory Pattern

## Overview
This repository demonstrates the Abstract Factory design pattern using a simple furniture factory example. The Abstract Factory pattern is a creational design pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes.

In this example, we have four main interfaces:
* **ISofa**: Defines the properties of a sofa.
* **IChair**: Defines the properties of a chair.
* **ITable**: Defines the properties of a table.
* **IFurnitureFactory**: Defines the factory methods to create ISofa, IChair, and ITable instances.

Six concrete implementations for each furniture type are provided:
* **VintageSofa, VintageChair, VintageTable**: Implementations following a vintage style.
* **ModernSofa, ModernChair, ModernTable**: Implementations following a modern style.

## Usage
To use the furniture factory, you'll need to instantiate it and then create the furniture.

```
IFurnitureFactory furnitureFactory = new VintageFurnitureFactory();
ISofa sofa = furnitureFactory.CreateSofa();
IChair chair = furnitureFactory.CreateChair();
ITable table = furnitureFactory.CreateTable();
```
Or
```
IFurnitureFactory furnitureFactory = new ModernFurnitureFactory();
ISofa sofa = furnitureFactory.CreateSofa();
IChair chair = furnitureFactory.CreateChair();
ITable table = furnitureFactory.CreateTable();
```