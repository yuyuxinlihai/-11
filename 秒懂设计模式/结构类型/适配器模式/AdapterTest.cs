using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.适配器模式
{

    /// <summary>
    /// 适配器模式
    /// </summary>
    public class AdapterTest
    {       
        public static void Show()
        {
            DualPin dual = new TV();
            TriplePin triplePin = new Adapter(dual);
            triplePin.Electrify(1,0,-1);

            TriplePin tVAdapter = new TVAdapter();
            tVAdapter.Electrify(1, 2, 3);
        }
    }


    public class Adapter: TriplePin
    {
        private DualPin dualPin;
        public Adapter(DualPin dualPin)
        {
            this.dualPin = dualPin;
        }

        public void Electrify(int l, int n, int e)
        {
            this.dualPin.Electrify(l,n);
        }

     
    }
    /// <summary>
    /// 三孔插口
    /// </summary>
    public interface TriplePin
    {
        void Electrify(int l, int n, int e);
    }
    /// <summary>
    /// 两孔接口
    /// </summary>
    public interface DualPin
    {
        void Electrify(int l, int n);
    }

    public class TV : DualPin
    {
        public void Electrify(int l, int n)
        {
            Console.WriteLine($"火线通电{l}零线通电{n}");
        }
    }

    public class TVAdapter : TV, TriplePin
    {
        public void Electrify(int l, int n, int e)
        {
           base.Electrify(l,n);
        }
    }
}
