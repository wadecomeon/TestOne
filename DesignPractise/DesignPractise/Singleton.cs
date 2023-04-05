using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPractise
{
    public class Singleton
    {
        //私有构造函数，使其外部不能通过new创建实例
        private Singleton() 
        { 

        }

        private static  Singleton Instance = null;

        private static readonly Object LockObj = new object();

        //提供全局访问点创建实例
        public static Singleton GetInstance()
        {
            if(Instance== null)
            {
                lock (LockObj)
                {
                    if(Instance==null)
                    {
                        Instance = new Singleton();
                    }
                }
            }
            return Instance;
        }
    }

    public class SingletonOther
    {
        //私有构造函数，使其外部不能通过new创建实例
        private SingletonOther()
        {

        }

        public static SingletonOther Instance = new SingletonOther();

        //private static readonly Object LockObj = new object();

        //提供全局访问点创建实例
        //public static Singleton GetInstance()
        //{
        //    if (Instance == null)
        //    {
        //        lock (LockObj)
        //        {
        //            if (Instance == null)
        //            {
        //                Instance = new Singleton();
        //            }
        //        }
        //    }
        //    return Instance;
        //}

        public static void Test()
        {
            Console.WriteLine("饿汉模式");
        }
    }
}
