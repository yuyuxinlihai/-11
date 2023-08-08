using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.责任链模式
{
    public class StaffTest
    {
        public static void Show()
        {
            Approver approver = new Staff("张飞");
            approver.SetNextApprover(new Manager("关羽")).SetNextApprover(new CFO("刘备"));
            approver.Approve(5000);
        }
    }
    public abstract class Approver
    {
        protected string name;
        protected Approver nextApprover;
        protected Approver(string name)
        {
            this.name = name;
        }
        public Approver SetNextApprover(Approver nextApprover)
        {
            this.nextApprover = nextApprover;
            return this.nextApprover;
        }
        public abstract void Approve(int amount);
    }

    public class Staff : Approver
    {
        public string Name { get; set; }
        public Staff(string name) : base(name)
        {
        }
        public override void Approve(int amount)
        {
            if (amount <= 1000)
            {
                Console.WriteLine($"审批请过,专员{name}");
            }
            else
            {
                Console.WriteLine($"无权审批,升级处理,专员{name}");
                this.nextApprover.Approve(amount);
            }

        }
    }

    public class Manager : Approver
    {
        private string name;

        public Manager(string name) : base(name)
        {
        }


        public override void Approve(int amount)
        {
            if (amount <= 5000)
            {
                Console.WriteLine($"审批请过,经理{name}");
            }
            else
            {
                Console.WriteLine($"无权审批,升级处理,经理{name}");
                this.nextApprover.Approve(amount);
            }
        }
    }

    public class CFO : Approver
    {
        private string name;

        public CFO(string name) : base(name)
        {
        }

        public override void Approve(int amount)
        {
            if (amount <= 10000)
            {
                Console.WriteLine($"审批请过,财务总监{name}");
            }
            else
            {
                Console.WriteLine($"驳回申请财务总监{name}");
                this.nextApprover.Approve(amount);
            }
        }
    }



}
