using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.状态模式
{
    public class StateTest
    {
        public void Show()
        {
            Switcher s = new Switcher();
            s.SwitchOff();
            s.SwitchOn();
        }


    }
    public class Switcher
    {
        private bool state = false;
        public void SwitchOn()
        {
            state = true;
            Console.WriteLine("灯亮");
        }
        public void SwitchOff()
        {
            state = false;
            Console.WriteLine("灯灭");
        }
    }

    public class TrafficLight
    {
        string state = "红";
        public void SwitchToGree()
        {
            if ("绿".Equals(state))
            {
                Console.WriteLine("绿灯状态");
            }
        }
        public void SwitchToYellow()
        {
            if ("黄".Equals(state))
            {
                Console.WriteLine("黄色状态");
            }
        }
    }

    public interface State
    {
        void SwitchToGreen(TrafficLight trafficLight);
        void SwitchToYellow(TrafficLight trafficLight);
        void SwitchToRed(TrafficLight trafficLight);
    }


    public class Red : State
    {
        public void SwitchToGreen(TrafficLight trafficLight)
        {
            Console.WriteLine("红灯");
        }

        public void SwitchToRed(TrafficLight trafficLight)
        {

        }

        public void SwitchToYellow(TrafficLight trafficLight)
        {
            throw new NotImplementedException();
        }
    }
}
