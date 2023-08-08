using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.结构类型.组合模式
{
    /// <summary>
    /// 组合模式 针对树形节点层次结构
    /// </summary>
    public class CompositeTest
    {
        public static void Show()
        {
            Node doc = new Folder("文档");
            doc.Add(new File("哈哈"));
            doc.GetChildrens().ForEach(item => Console.WriteLine(item.Name));

        }
    }
   

    public abstract class Node
    {
        private string name;

        protected Node(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }

        //添加下级节点方法
        public abstract void Add(Node child);

        public virtual List<Node> GetChildrens()
        {
            return new List<Node>();
        }


    }
    /// <summary>
    /// 文件夹
    /// </summary>
    public class Folder : Node
    {
        private List<Node> childerenNodes = new List<Node>();


        public Folder(string name) : base(name)
        {
        }

        public override void Add(Node child)
        {
            childerenNodes.Add(child);
        }

        public override List<Node> GetChildrens()
        {
            return childerenNodes;
        }
    }

    /// <summary>
    /// 文件-文件下没有子节点
    /// </summary>
    public class File : Node
    {
        public File(string name) : base(name)
        {
        }

        public override void Add(Node child)
        {
            Console.WriteLine("不能添加子节点");
        }
    }
}
