using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.原型模式
{

    /// <summary>
    /// 原型模式
    /// </summary>
    public class Prototype
    {

    }
    public class EnemyPlane
    {
        public int X { get; set; } = 0;
        public int Y { get; private set; }

        public EnemyPlane(int x)
        {
            this.X = x;
        }

        public void Fly()
        {
            this.Y++;
        }


        public EnemyPlane Clone()
        {
            return (EnemyPlane)this.MemberwiseClone();
        }
    }

    public class EnemyPlaneFactory
    {
        private static EnemyPlane protoType = new EnemyPlane(200);
        public static EnemyPlane getInstance(int x)
        {
            EnemyPlane clone = protoType.Clone();
            clone.X = x;
            return clone;
        }
    }


    public class Client
    {
        public List<EnemyPlane> Players { get; set; }

        public Client()
        {
            Players = new List<EnemyPlane>();
        }
        public void SetEnemyPlane()
        {
            for (int i = 0; i < 500; i++)
            {
                EnemyPlane enemyPlane = new EnemyPlane(Random.Shared.Next(200));
                Players.Add(enemyPlane);
            }
        }
    }
}
