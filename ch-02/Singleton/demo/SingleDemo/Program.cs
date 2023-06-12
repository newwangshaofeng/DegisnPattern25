namespace SingleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                System.Console.WriteLine("s1 == s2");
            }
            else
            {
                System.Console.WriteLine("s1 != s2");
            }


            Console.WriteLine("Hello, World!");
        }
    }
}