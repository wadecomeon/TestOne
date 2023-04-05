using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPractise
{
    /// <summary>
    /// 举例阐述抽象工厂模式：
///假如中国对邪恶国家开战。

///中国装备：炸弹类，坦克类，来消灭邪恶国家。

///炸弹类：导弹，核弹；

///坦克类：越野车，主站坦克；

///战略：

///前期中国兵工厂生产：导弹，越野车，打击邪恶国家。

///后期中国兵工厂生产：核弹，主站坦克，毁灭邪恶国家。
    /// </summary>
    public class AbstrctFactory
    {
    }

    public abstract class Bomb
    {
        public abstract void BaoZha();
    }

    public abstract class Tank
    {
        public abstract void Go();
    }

    public class HeDan : Bomb
    {
        public override void BaoZha()
        {
            Console.WriteLine("核弹爆炸！");
        }
    }

    public class DaoDan : Bomb
    {
        public override void BaoZha()
        {
            Console.WriteLine("导弹爆炸！");
        }
    }

    public class BuBin : Tank
    {
        public override void Go()
        {
            Console.WriteLine("步宾前进！");
        }
    }

    public class TanKe : Tank
    {
        public override void Go()
        {
            Console.WriteLine("坦克前进！");
        }
    }

    public abstract class ChinaFactory
    {
        //一个制造坦克
        public abstract Tank CreateTank();
        //一个制造导弹
        public abstract Bomb CreateBomb();
    }

    public class QianQi : ChinaFactory
    {
        public override Tank CreateTank()
        {
            return new BuBin();
        }

        public override Bomb CreateBomb()
        {
            return new DaoDan();
        }
    }

    public class HouQi : ChinaFactory
    {
        public override Tank CreateTank()
        {
            return new TanKe();
        }

        public override Bomb CreateBomb()
        {
            return new HeDan();
        }
    }

    public class Make
    {
        private Tank tank;
        private Bomb bomb;
        public Make(ChinaFactory factory)
        {
            tank = factory.CreateTank();
            bomb = factory.CreateBomb();
        }

        public void BeginWar()
        {
            tank.Go();
            bomb.BaoZha();
        }
    }
}
