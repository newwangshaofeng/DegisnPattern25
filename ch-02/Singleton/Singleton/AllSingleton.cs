using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// �����ڶ��߳��뵥�߳�
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
