using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AbsFactory
    {

        //实现一个AbstractFactory抽象工厂模式示例
        public static void Main()
        {
            //创建一个工厂
            IFactory factory = new Factory();
            //创建一个产品A
            IProductA productA = factory.CreateProductA();
            //创建一个产品B
            IProductB productB = factory.CreateProductB();
            //调用产品A的方法
            productA.MethodA();
            //调用产品B的方法
            productB.MethodB();


            Console.Read();
        }





    }

    public class Factory : IFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public interface IProductB
    {
        void MethodB();
    }

    public interface IProductA
    {
        void MethodA();
    }


    public class ProductA1 : IProductA
    {
        public void MethodA()
        {
            Console.WriteLine("ProductA1::MethodA()");
        }
    }

    public class ProductA2 : IProductA
    {
        public void MethodA()
        {
            Console.WriteLine("ProductA2::MethodA()");
        }
    }

    public class ProductB1 : IProductB
    {
        public void MethodB()
        {
            Console.WriteLine("ProductB1::MethodB()");
        }
    }

    public class ProductB2 : IProductB
    {
        public void MethodB()
        {
            Console.WriteLine("ProductB2::MethodB()");
        }
    }




}
