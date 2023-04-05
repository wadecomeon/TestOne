namespace DesignPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //单例模式
            {
                Console.WriteLine("Hello, World!");
                //单例模式
                Singleton singleton1 = Singleton.GetInstance();
                Singleton singleton2 = Singleton.GetInstance();
                if (singleton1 == singleton2)
                {
                    Console.WriteLine("实例相同");
                }

                SingletonOther singleton3 = SingletonOther.Instance;
                SingletonOther singleton4 = SingletonOther.Instance;
                SingletonOther.Test();
                if (singleton3 == singleton4)
                {
                    Console.WriteLine("饿汉也是相同实例");
                }
            }
            //抽象工厂模式
            {
                ChinaFactory qianQi = new QianQi();
                Make make = new Make(qianQi);
                make.BeginWar();

                ChinaFactory houQi = new HouQi();
                Make make1 = new Make(houQi);
                make1.BeginWar();
            }
            
        }
    }
}