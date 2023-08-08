using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.抽象工厂模式
{

    public class AbstractFactoryTest
    {
        public static void Show()
        {
            //人族工厂
            AbstractFactory humanFactory = new HumanFactory();
            //人族工厂-低级兵
            humanFactory.CreateLowClass().Show();
            //人族工厂-中级兵
            humanFactory.CreateMidClass().Show();
            //人族工厂-高级兵
            humanFactory.CreateHighClass().Show();

            //外星种族工厂
            AbstractFactory alienFactory =new AlienFactory();
            //外星种族工厂-低级兵
            alienFactory.CreateLowClass().Show();
            //外星种族工厂-中级兵
            alienFactory.CreateMidClass().Show();
            //外星种族工厂-高级兵
            alienFactory.CreateHighClass().Show();
        }

    }

    public interface AbstractFactory
    {
        LowClassUnit CreateLowClass();
        MidClassUnit CreateMidClass();
        HighClassUnit CreateHighClass();
    }
    public class HumanFactory : AbstractFactory
    {
        public HighClassUnit CreateHighClass()
        {
            HighClassUnit unit = new BattleShip(12, 3);
            return unit;
        }

        public LowClassUnit CreateLowClass()
        {
            LowClassUnit unit = new Marien(1, 2);
            return unit;
        }

        public MidClassUnit CreateMidClass()
        {
            MidClassUnit unit = new Tank(2, 3);
            return unit;
        }
    }

    /// <summary>
    /// 外星种族
    /// </summary>
    public class AlienFactory : AbstractFactory
    {
        /// <summary>
        /// 高级兵种
        /// </summary>
        /// <returns></returns>
        public HighClassUnit CreateHighClass()
        {
            return new Mammoth(1, 2);
        }
        /// <summary>
        /// 初级兵种
        /// </summary>
        /// <returns></returns>
        public LowClassUnit CreateLowClass()
        {
            return new Roach(12, 3);
        }
        /// <summary>
        /// 中级兵种
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public MidClassUnit CreateMidClass()
        {
            return new Posion(1, 3);
        }
    }


    public abstract class Unit
    {
        /// <summary>
        /// 攻击力
        /// </summary>
        protected int attack;
        /// <summary>
        /// 防御力
        /// </summary>
        protected int defence;
        /// <summary>
        /// 生命力
        /// </summary>
        protected int health;
        /// <summary>
        /// 横坐标
        /// </summary>
        protected int x;
        /// <summary>
        /// 纵坐标
        /// </summary>
        protected int y;

        protected Unit(int attack, int defence, int health, int x, int y)
        {
            this.attack = attack;
            this.defence = defence;
            this.health = health;
            this.x = x;
            this.y = y;
        }

        public abstract void Show();
        public abstract void Attck();
    }
    /// <summary>
    /// 初级兵种
    /// </summary>
    public abstract class LowClassUnit : Unit
    {
        protected LowClassUnit(int x, int y) : base(5, 2, 35, x, y)
        {
        }
    }
    /// <summary>
    /// 中级兵种
    /// </summary>
    public abstract class MidClassUnit : Unit
    {
        protected MidClassUnit(int x, int y) : base(10, 8, 80, x, y)
        {
        }
    }
    /// <summary>
    /// 高级兵种
    /// </summary>
    public abstract class HighClassUnit : Unit
    {
        protected HighClassUnit(int x, int y) : base(25, 30, 300, x, y)
        {
        }
    }



    /// <summary>
    ///初级兵种- 海军陆战队
    /// </summary>
    public class Marien : LowClassUnit
    {
        public Marien(int x, int y) : base(x, y)
        {
        }

        public override void Attck()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            Console.WriteLine("海军陆战队");
        }
    }
    /// <summary>
    /// 中级兵种-坦克
    /// </summary>
    public class Tank : MidClassUnit
    {
        public Tank(int x, int y) : base(x, y)
        {
        }

        public override void Attck()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            Console.WriteLine("坦克");
        }
    }
    /// <summary>
    /// 高级兵种-战舰
    /// </summary>
    public class BattleShip : HighClassUnit
    {
        public BattleShip(int x, int y) : base(x, y)
        {
        }

        public override void Attck()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            Console.WriteLine("战舰");
        }
    }
    /// <summary>
    /// 初级兵种-蟑螂
    /// </summary>
    public class Roach : LowClassUnit
    {
        public Roach(int x, int y) : base(x, y)
        {
        }

        public override void Attck()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            Console.WriteLine("蟑螂");
        }
    }

    /// <summary>
    /// 中级兵种-毒液
    /// </summary>
    public class Posion :MidClassUnit
    {
        public Posion(int x, int y) : base(x, y)
        {
        }

        public override void Attck()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            Console.WriteLine("毒液");
        }
    }

    /// <summary>
    /// 高级兵种-猛犸
    /// </summary>
    public class Mammoth : HighClassUnit
    {
        public Mammoth(int x, int y) : base(x, y)
        {
        }

        public override void Attck()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            Console.WriteLine("猛犸");
        }
    }
}
