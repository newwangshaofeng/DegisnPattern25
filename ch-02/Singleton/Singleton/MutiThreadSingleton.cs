using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// 适用于多线程
    /// </summary>
    public class MultiThreadSingleton
    {
        private static volatile MultiThreadSingleton instance = null;

        private static object lockHelper = new object();

        private MultiThreadSingleton()
        {
        }

        public static MultiThreadSingleton Instance
        {
            get
            {
                if( instance == null )
                {
                    lock( lockHelper )
                    {
                        if( instance == null )
                        {
                            instance = new MultiThreadSingleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
