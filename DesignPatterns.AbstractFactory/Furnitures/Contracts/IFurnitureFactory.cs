namespace DesignPatterns.AbstractFactory.Furnitures.Contracts
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ITable CreateTable();
        ISofa CreateSofa();
    }
}
