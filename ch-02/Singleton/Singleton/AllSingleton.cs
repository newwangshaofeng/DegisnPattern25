using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// 适用于多线程与单线程
    /// </summary>
    public class AllSingleton
    {
        public static readonly AllSingleton Instance = new AllSingleton();

        private AllSingleton()
        {
        }
    }

    //public class AllSingleton
    //{
    //    public static readonly AllSingleton Instance;

    //    static AllSingleton()
    //    {
    //        Instance = new AllSingleton();
    //    }

    //    private AllSingleton()
    //    {
    //    }
    //}
}
