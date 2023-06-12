using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// 适用于单线程
    /// </summary>
    public class Singleton
    {
        private static Singleton instance;
        int x, y;

        private Singleton()
        {
        }
        public static Singleton Instance
        {
            get
            {
                if( instance == null )
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        private Singleton( int x, int y )
        {
            this.x = x;
            this.y = y;
        }

        public static Singleton GetInstance(int x,int y)
        {
            if( instance == null )
            {
                instance = new Singleton( x, y );
            }
            else
            {
                instance.x = x;
                instance.y = y;
            }

            return instance;
        }
    }
}
