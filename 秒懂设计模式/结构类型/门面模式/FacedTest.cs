using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.门面模式
{
    /// <summary>
    /// 门面模式 就是整合共享
    /// </summary>
    public class FacedTest
    {
        public static void Show()
        {
            Faced faced = new Faced();
        }
    }


    public class Faced
    {
        public Faced()
        {
            Vegvendor vegvendor = new Vegvendor();
            vegvendor.Purchase();
            //
            Chef chef = new Chef();
            Waiter waiter = new Waiter();
            Cleaner cleaner = new Cleaner();
        }
    }

    public class Vegvendor
    {
        public void Purchase()
        {
            Console.WriteLine("供应蔬菜");
        }
    }
    /// <summary>
    /// 厨房小能手类
    /// </summary>
    public class Helper
    {
        public void Cook()
        {
            Console.WriteLine("下厨烹饪");
        }
    }

    public class Chef
    {

    }

    public class Waiter
    {

    }

    public class Cleaner
    {

    }
}
