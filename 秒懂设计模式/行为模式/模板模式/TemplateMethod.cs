using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.模板模式
{
    public class TemplateMethod
    {
        public static void Show()
        {
            PM pm = new HRProject();
            pm.Release("");
           
        }
    }

    public abstract class Mammal
    {
        public abstract void Move();

        public abstract void Eat();

        public void Live()
        {
            Move();
            Eat();
        }
    }


    public class Whale : Mammal
    {
        public void Live()
        {
            Move();
            Eat();
        }

        public override void Move()
        {
            Console.WriteLine("鲸鱼在水里游者");
        }

        public override void Eat()
        {
            Console.WriteLine("捕鱼吃");
        }
    }


    public class Human : Mammal
    {
        public void Live()
        {
            Move();
            Eat();
        }

        public override void Move()
        {
            Console.WriteLine("人类在水里游者");
        }

        public override void Eat()
        {
            Console.WriteLine("人类捕鱼吃");
        }
    }


    public abstract class PM
    {
        public abstract string Analyze();

        public abstract string Design(string project);

        public abstract string Release(string project);

        protected void KickOff()
        {

        }
    }

    public class HRProject : PM
    {
        public override string Analyze()
        {
            throw new NotImplementedException();
        }

        public override string Design(string project)
        {
            throw new NotImplementedException();
        }

        public override string Release(string project)
        {
            Console.WriteLine(project);
            return "";
        }
    }
}
