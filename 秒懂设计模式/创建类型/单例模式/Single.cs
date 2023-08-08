using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.单例模式
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public class Single
    {
        public void Show()
        {
            //饿汉模式
            IInfo sun = Sun.GetInstance();
            sun.Show();
            //懒汉模式
            IInfo sunLazy = SunLazy.GetInstance();
            sunLazy.Show();
            //双检锁
            IInfo sunMoreThread = SunMoreThread.GetInstance();
            sunMoreThread.Show();
        }

    }
    /// <summary>
    /// 显示信息
    /// </summary>
    public interface IInfo
    {
        void Show();
    }

    /// <summary>
    /// 饿汉模式
    /// </summary>
    public class Sun : IInfo
    {
        private static Sun sun = new Sun();
        private Sun()
        {

        }
        public static Sun GetInstance()
        {
            return sun;
        }
        public void Show()
        {
            Console.WriteLine($@"饿汉单例模式：直接声明静态私有变量并赋值，生命周期是直到应用程序关闭因为他是静态的");
        }
    }


    /// <summary>
    /// 懒汉模式
    /// </summary>
    public class SunLazy : IInfo
    {
        private static SunLazy sunLazy = null;
        private SunLazy()
        {

        }
        public static SunLazy GetInstance()
        {
            if (sunLazy == null)
            {
                sunLazy = new SunLazy();
            }
            return sunLazy;
        }

        public void Show()
        {
            Console.WriteLine($@"懒汉单例模式：直接声明静态私有变量不赋值，生命周期是直到应用程序关闭因为他是静态的");
        }
    }
    /// <summary>
    /// 多线程双检锁
    /// </summary>
    public class SunMoreThread : IInfo
    {
        private static SunMoreThread sunMoreThread = null;
        private static object lockObject = new object();
        private SunMoreThread()
        {

        }
        public static SunMoreThread GetInstance()
        {
            if (sunMoreThread == null)
            {
                lock (lockObject)
                {
                    if (sunMoreThread == null)
                    {
                        sunMoreThread = new SunMoreThread();
                    }
                }
            }
            return sunMoreThread;
        }
        public void Show()
        {
            Console.WriteLine($@"多线程双检锁");
        }
    }
}
