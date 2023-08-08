using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.代理模式
{
    /// <summary>
    /// 代理模式
    /// </summary>
    public class Proxy
    {
        public static void Show()
        {
            Internet prox =new RouterProxy();
            prox.HttpAccess("htt://www.电影.com");

        }
    }
    /// <summary>
    /// 互联网访问接口
    /// </summary>
    public interface Internet
    {
        void HttpAccess(string url);
    }
    /// <summary>
    /// 调制解调器
    /// </summary>
    public class Modem : Internet
    {
        public void HttpAccess(string url)
        {
            Console.WriteLine($"{url}");
        }
    }
    /// <summary>
    /// 路由器
    /// </summary>
    public class RouterProxy : Internet
    {
        private Internet modem;
        private List<string> blackList = new List<string> {"电影","游戏","音乐","小说" };

        public RouterProxy()
        {
            this.modem = new Modem();
        }

        public void HttpAccess(string url)
        {
            foreach (var item in blackList)
            {
                if (url.Contains(item))
                {
                    Console.WriteLine($"禁止访问{item}");
                    return;
                }
            }
            modem.HttpAccess(url);
        }
    }
}
