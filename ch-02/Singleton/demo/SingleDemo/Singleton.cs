using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDemo
{
   
    internal class Singleton
    {
        //普通模式实现单例模式，不支持多线程
        // private static Singleton _instance;
        // private Singleton() { }
        // public static Singleton GetInstance()
        // {
        //     if (_instance == null)
        //     {
        //         _instance = new Singleton();
        //     }
        //     return _instance;
        // }
        //

        //帮我写一个单例模式,使用静态的私有的本类对象
        // private static Singleton _instance = new Singleton();
        // private Singleton() { }
        //
        // public static Singleton GetInstance()
        // {
        //     return _instance;
        // }
            

        //换个写法，双检查实现单例模式
        private static Singleton _instance;
        private static readonly object _lock = new object();
        private Singleton() { }
         
        public static Singleton GetInstance()
        {
            if (_instance==null)
            {
                lock (_lock)
                {
                    if (_instance==null)
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }

    }
}
