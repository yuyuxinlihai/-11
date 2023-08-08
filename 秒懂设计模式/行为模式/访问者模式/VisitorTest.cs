using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.访问者模式
{
    public class VisitorTest
    {

        public void Show()
        {
            List<Acceptable> products = new List<Acceptable>();
            products.Add(new Candy("奶糖",DateTime.Now,20));
            products.Add(new Wine("奶糖", DateTime.Now, 20));
            products.Add(new Fruit("草莓", DateTime.Now, 20));

            //Visitor discountVisitor = new DiscountVisitor(,);
        }
    }

    public abstract class Product
    {
        private string name;
        private DateTime producedDate;
        private float price;

        protected Product(string name, DateTime producedDate, float price)
        {
            this.name = name;
            this.producedDate = producedDate;
            this.price = price;
        }

        public string Name { get => name; set => name = value; }
        public DateTime ProducedDate { get => producedDate; set => producedDate = value; }

        public float Price { get => price; set => price = value; }


    }

    public class Candy : Product, Acceptable
    {
        public Candy(string name, DateTime producedDate, float price) : base(name, producedDate, price)
        {
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Wine : Product, Acceptable
    {
        public Wine(string name, DateTime producedDate, float price) : base(name, producedDate, price)
        {
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Fruit : Product, Acceptable
    {
        public Fruit(string name, DateTime producedDate, float price) : base(name, producedDate, price)
        {
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public interface Visitor
    {
        public void Visit(Candy candy);
        public void Visit(Wine wine);
        public void Visit(Fruit fruit);
    }

    public class DiscountVisitor : Visitor
    {
        public void Visit(Candy candy)
        {
            throw new NotImplementedException();
        }

        public void Visit(Wine wine)
        {
            throw new NotImplementedException();
        }

        public void Visit(Fruit fruit)
        {
            throw new NotImplementedException();
        }
    }

    public interface Acceptable
    {
        public void Accept(Visitor visitor);
    }
}
