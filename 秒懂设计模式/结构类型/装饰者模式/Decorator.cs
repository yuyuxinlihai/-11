using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.装饰者模式
{
    /// <summary>
    /// 装饰者模式
    /// </summary>
    public class DecoratorTest
    {
        public static void Show()
        {
            Showable madeupGirl = new Lipstick(new FoundationMakeUp(new Girl()));
            madeupGirl.Show();
        }
    }


    public interface Showable
    {
        /// <summary>
        /// 展示行为
        /// </summary>
        void Show();
    }

    public class Girl : Showable
    {
        public void Show()
        {
            Console.WriteLine("我是一个女孩");
        }
    }
    /// <summary>
    /// 化妆品装饰类
    /// </summary>
    public class Decorator : Showable
    {
        public Showable showable { get; set; }
        public Decorator(Showable showable)
        {
            this.showable = showable;
        }

        public virtual void Show()
        {
            this.showable.Show();
        }
    }
    /// <summary>
    /// 粉底装饰类
    /// </summary>
    public class FoundationMakeUp : Decorator
    {
        public FoundationMakeUp(Showable showable) : base(showable)
        {
        }
        public override void Show()
        {
            Console.WriteLine("[打粉底");
            showable.Show();
            Console.WriteLine("]");
        }
    }
    /// <summary>
    /// 口红装饰类
    /// </summary>
    public class Lipstick : Decorator
    {
        public Lipstick(Showable showable) : base(showable)
        {
        }
        public override void Show()
        {
            Console.WriteLine("[涂口红");
            showable.Show();
            Console.WriteLine("]");
        }
    }
}
