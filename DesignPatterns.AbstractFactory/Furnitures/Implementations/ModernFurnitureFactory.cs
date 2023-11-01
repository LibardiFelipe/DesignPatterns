using DesignPatterns.AbstractFactory.Furnitures.Contracts;
using DesignPatterns.AbstractFactory.Furnitures.Implementations.Furnitures.Modern;

namespace DesignPatterns.AbstractFactory.Furnitures.Implementations
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ModernChair();

        public ISofa CreateSofa() => new ModernSofa();

        public ITable CreateTable() => new ModernTable();
    }
}
