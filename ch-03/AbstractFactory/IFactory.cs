namespace AbstractFactory
{
    internal interface IFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }
}