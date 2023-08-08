using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 秒懂设计模式.原型模式;

namespace 秒懂设计模式.工厂模式
{
    /// <summary>
    /// 工厂模式
    /// </summary>
    public class FactoryTest
    {
        public static void Show()
        {
            new AirplaneFactory().Create(11).Show();
            new TankFactory().Create(12).Show();
            new BossFactory().Create(14).Show();
        }
    }
    public interface Factory
    {
        Enemy Create(int screenWidth);
    }

    public class AirplaneFactory : Factory
    {
        public Enemy Create(int screenWidth)
        {
            return new Airplane(Random.Shared.Next(screenWidth), 0);
        }
    }

    public class TankFactory : Factory
    {
        public Enemy Create(int screenWidth)
        {
            return new Tank(Random.Shared.Next(screenWidth), 0);
        }
    }

    public class BossFactory : Factory
    {
        public Enemy Create(int screenWidth)
        {
            return new Boss(Random.Shared.Next(screenWidth), 0);
        }
    }


    public abstract class Enemy
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Enemy(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract void Show();
    }

    public class Airplane : Enemy
    {
        public Airplane(int x, int y) : base(x, y)
        {
        }

        public override void Show()
        {
            Console.WriteLine("飞机");
        }
    }

    public class Tank : Enemy
    {
        public Tank(int x, int y) : base(x, y)
        {
        }

        public override void Show()
        {
            Console.WriteLine("坦克");
        }
    }

    public class Boss : Enemy
    {
        public Boss(int x, int y) : base(x, y)
        {
        }

        public override void Show()
        {
            Console.WriteLine("boss");
        }
    }

}
