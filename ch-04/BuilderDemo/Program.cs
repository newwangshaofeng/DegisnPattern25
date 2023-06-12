namespace BuilderDemo
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

        
            //具体生成器
          // IHouseBuilder builder = new SimpleHouseBuilder();

           IHouseBuilder builder = new SimpleHouseBuilder2();

           //指挥者
           Contractor contractor = new Contractor(builder);

           //指挥者指挥生成器生成产品
           House house = contractor.BuildHouse();
           //显示产品
           house.Display();






            Console.ReadKey();
        }
        

    }
}