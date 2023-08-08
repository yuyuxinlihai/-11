using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.享元模式
{
    /// <summary>
    /// 享元模式
    /// </summary>
    public class Flyweight
    {
        public void Show()
        {
            TitleFactory titleFactory = new TitleFactory();
            titleFactory.GetGrawable("河流").Draw(10,1);
        }
    }
    /// <summary>
    /// 绘图接口
    /// </summary>
    public interface Drawable
    {
        void Draw(int x, int y);
    }
    /// <summary>
    /// 河流类
    /// </summary>
    public class River : Drawable
    {
        string image;
        public River(string image)
        {
            this.image = image;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"河流位置{x},{y}");
        }
    }
    public class Title : Drawable
    {
        private string image;
        private int x, y;

        public Title(string image, int x, int y)
        {
            this.image = image;
            this.x = x;
            this.y = y;
        }

        public void Draw()
        {
            Console.WriteLine("绘制图片");
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"{x},{y}");
        }
    }
    /// <summary>
    /// 草地类
    /// </summary>
    public class Grass : Drawable
    {
        public void Draw(int x, int y)
        {
            Console.WriteLine($"草地{x},{y}");
        }
    }
    /// <summary>
    /// 石头类
    /// </summary>
    public class Stone : Drawable
    {
        public void Draw(int x, int y)
        {
            Console.WriteLine($"石头{x},{y}");
        }
    }
    /// <summary>
    /// 房间类
    /// </summary>
    public class House : Drawable
    {
        public void Draw(int x, int y)
        {
            Console.WriteLine($"房间{x},{y}");
        }
    }


    public class TitleFactory
    {
        Dictionary<string, Drawable> images = null;

        public TitleFactory()
        {
            this.images = new Dictionary<string, Drawable>();
        }

        public Drawable GetGrawable(string image)
        {
            if (!images.ContainsKey(image))
            {
                switch (image)
                {
                    case "河流":
                        images.Add(image, new River(image));
                        break;

                    default:
                        break;
                }
            }
            return images[image];
        }
    }
}
