using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.观察者模式
{
    internal class ObserverTest
    {
        public void Show()
        {
            Buyer trangSir = new PhoneFans("手机粉");
            Buyer barJee = new HandChopper("剁手族");
            Shop shop = new Shop();
            shop.Register(trangSir);
            shop.Register(barJee);
            shop.SetProduct("猪肉炖粉条");
            shop.SetProduct("橘子手机");
        }
    }

    public class Shop
    {
        private string product;

        public string Product { get => product; set => product = value; }

        private List<Buyer> buyerList;

        public Shop()
        {
            this.product = "无商品";
            this.buyerList = new List<Buyer>();
        }

        public void Register(Buyer buyer)
        {
            this.buyerList.Add(buyer);
        }

        public string GetProduct()
        {
            return product;
        }

        public void SetProduct(string product)
        {
            this.product = product;

        }

        public void NotifyBuyers()
        {
             buyerList.ForEach(item=>item.Inform(this.product));
        }
    }

    public abstract class Buyer
    {
        private string name;

        public Buyer(string name)
        {
            this.Name = name;

        }

        public string Name { get => name; set => name = value; }

        public abstract void Inform(string product);
    }

    public class PhoneFans : Buyer
    {
        public PhoneFans(string name) : base(name)
        {
        }

        public override void Inform(string product)
        {
            Console.WriteLine("购买"+product);
        }
    }

    public class HandChopper : Buyer
    {
        public HandChopper(string name) : base(name)
        {
        }

        public override void Inform(string product)
        {
            Console.WriteLine("购买"+product);
        }
    }
}
