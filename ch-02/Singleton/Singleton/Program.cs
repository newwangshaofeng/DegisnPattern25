using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton t1 = Singleton.Instance;
            Singleton t2 = Singleton.Instance;

            Console.WriteLine(object.Equals(t1, t2));
        }
    }
}
