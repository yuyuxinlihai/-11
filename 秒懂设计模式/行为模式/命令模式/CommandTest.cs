using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.命令模式
{
    public class CommandTest
    {
        public void Show()
        {
            Switcher switcher = new Switcher();
            Bulb bulb = new Bulb();
            Command swithCommand = new SwitcherCommand(bulb);

            switcher.SetCommand(swithCommand);
            switcher.ButtonPush();
            switcher.ButtonPo();
        }
    }

    public class Bulb
    {
        public void On()
        {
            Console.WriteLine("灯亮");
        }

        public void Off()
        {
            Console.WriteLine("灯灭");
        }

    }

    public class SwitcherCommand : Command
    {
        private Bulb bulb;

        public SwitcherCommand(Bulb bulb)
        {
            this.bulb = bulb;
        }

        public void Exe()
        {
            bulb.On();
        }

        public void UnExe()
        {
            bulb.Off();
        }
    }


    public interface Command
    {
        void Exe();
        void UnExe();
    }

    public class Switcher
    {
        private Command command;
        public void SetCommand(Command command)
        {
            this.command = command;
        }
        public void ButtonPush()
        {
            command.Exe();
        }

        public void ButtonPo()
        {
            command.UnExe();
        }
    }

    public class FlashCommand : Command
    {
        private Bulb bulb;
        public FlashCommand(Bulb Bulb)
        {
            bulb = Bulb;
        }
        public void Exe()
        {
            throw new NotImplementedException();
        }

        public void UnExe()
        {
            throw new NotImplementedException();
        }
    }
}
