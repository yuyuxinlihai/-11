using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.桥接模式
{
    public class Bridge
    {
        public static void Show()
        {
            new WhitePen(new CircleRuler()).Draw();
            new WhitePen(new SquareRuler()).Draw();
            new BlackPen(new TraiangleRuler()).Draw();
        }
    }

    public abstract class Pen
    {
        protected Ruler ruler;

        protected Pen(Ruler ruler)
        {
            this.ruler = ruler;
        }

        public abstract void GetColor();
        public void Draw()
        {
            GetColor();
        }
    }

    public class BlackPen : Pen
    {
        public BlackPen(Ruler ruler) : base(ruler)
        {
        }

        public override void GetColor()
        {
            Console.WriteLine("黑");
        }
    }

    public interface Ruler
    {
        void Regularize();    
    }

    public class SquareRuler : Ruler
    {
        public void Regularize()
        {
            Console.WriteLine("圆");
        }
    }

    public class TraiangleRuler : Ruler
    {
        public void Regularize()
        {
            Console.WriteLine("方块");
        }
    }

    public class CircleRuler : Ruler
    {
        public void Regularize()
        {
            Console.WriteLine("圈");
        }
    }

    public class WhitePen : Pen
    {
        public WhitePen(Ruler ruler) : base(ruler)
        {
        }

        public override void GetColor()
        {
            Console.WriteLine("白色");
        }
    }
}
