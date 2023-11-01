using DesignPatterns.AbstractFactory.Furnitures.Contracts;
using DesignPatterns.AbstractFactory.Furnitures.Implementations.Furnitures.Vintage;

namespace DesignPatterns.AbstractFactory.Furnitures.Implementations
{
    public class VintageFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new VintageChair();

        public ITable CreateTable() => new VintageTable();

        public ISofa CreateSofa() => new VintageSofa();
    }
}
