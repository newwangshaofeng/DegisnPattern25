namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            //设计模式：工程方法模式
            //定义一个用于创建对象的接口，让子类决定实例化哪一个类。
            //工厂方法使一个类的实例化延迟到其子类。
            //工厂方法模式又称为工厂模式，也叫虚拟构造器(Virtual Constructor)模式或者多态工厂(Polymorphic Factory)模式。
            //工厂方法模式是一种类创建型模式。

            Creator creatorA = new ConcreteCreatorA();
            var productA = creatorA.FactoryMethod();   
            productA.Operation();


            Creator creatorB = new ConcreteCreatorB();
            var productb = creatorB.FactoryMethod();   
            productb.Operation();



            Console.Read();
        }
    }

    abstract class Product
    {
        public abstract void Operation();
    }

    class ConcreteProductA : Product
    {
        public override void Operation()
        {
            System.Console.WriteLine("ConcreteProductA");
        }
    }

    class ConcreteProductB : Product
    {
        public override void Operation()
        {
            System.Console.WriteLine("ConcreteProductB");
        }
    }

    abstract class Creator
    {
        public abstract Product FactoryMethod();

        public void Operation()
        {
            Product product = FactoryMethod();
            product.Operation();
        }
    }

    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}