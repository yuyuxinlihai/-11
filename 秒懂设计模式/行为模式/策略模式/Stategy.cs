using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.策略模式
{
    public class StategyTest
    {

        public static void Show()
        {
            Calculator calculator = new Calculator();
            calculator.SetStrategy(new Addition());
            calculator.GetResult(1, 2);

            Computer computer = new Computer();
            computer.SetUSB(new KeyBoard());
            computer.Compute();
        }

    }
    public interface Strategy
    {
        int Calculate(int a, int b);
    }

    public class Calculator
    {
        private Strategy strategy;
        public void SetStrategy(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public int GetResult(int a, int b)
        {
            return this.strategy.Calculate(a, b);
        }

    }

    public class Addition : Strategy
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }

    public class Subtraction : Strategy
    {
        public int Calculate(int a, int b)
        {
            return a - b;
        }
    }

    public interface USB
    {
        void Read();
    }

    public class KeyBoard : USB
    {
        public void Read()
        {
            Console.WriteLine("键盘指令数据");
        }
    }

    public class Mouse : USB
    {
        public void Read()
        {
            Console.WriteLine("鼠标指令数据");
        }
    }

    public class Camera : USB
    {
        public void Read()
        {
            Console.WriteLine("视频流数据");
        }
    }

    public class Computer
    {
        private USB usb;

        public void SetUSB(USB usb)
        {
            this.usb = usb;
        }

        public void Compute()
        {

            usb.Read();
        }
    }
}
