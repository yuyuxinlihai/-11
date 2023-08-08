using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.创建类型.简单工厂模式
{
    /// <summary>
    /// 简单工厂
    /// </summary>
    public class SimpleFactoryTest
    {
        public static void Show()
        {
            //创建飞机
            SimpleFactory.Create(EnemyType.Airplane).Show();
            //创建坦克
            SimpleFactory.Create(EnemyType.Tank).Show();
            //创建Boss
            SimpleFactory.Create(EnemyType.Boss).Show();
        }
    }

    public class SimpleFactory
    {
        public static Enemy Create(EnemyType type)
        {
            switch (type)
            {
                case EnemyType.Airplane:
                    return new Airplane(1, 2);
                case EnemyType.Tank:
                    return new Tank(1, 2);
                case EnemyType.Boss:
                    return new Boss(1, 2);
                default:
                    return new Airplane(1, 2);
            }
        }
    }

    public enum EnemyType
    {
        Airplane,
        Tank,
        Boss
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
