using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.备忘录模式
{
    public interface IHistory
    {
    }
    public class History
    {
        private string body;

        public History(string body)
        {
            this.body = body;
        }

        public string Body { get => body; set => body = value; }


    }

    public class Doc
    {
        private string title;
        private string body;

        public Doc(string title)
        {
            this.title = title;
            this.body = "";
        }

        public string Title { get => title; set => title = value; }
        public string Body { get => body; set => body = value; }

        public History CreateHistory()
        {
            return new History(body);
        }

        public void RestoreHistory(History history)
        {
            this.body = history.Body;
        }
    }

    public class Editor
    {
        private Doc doc;
        public Editor(Doc doc)
        {
            this.doc = doc;
            this.Show();
        }


        public void Append(string txt)
        {
            doc.Body = doc.Body + txt;
        }

        public void Delete()
        {
            doc.Body = "";

        }

        public void Save()
        {

            Console.WriteLine("存盘");
        }

        public void Show()
        {
            Console.WriteLine(doc.Body);
            Console.WriteLine("文档结束");
        }
    }
}
