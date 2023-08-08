using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.中介模式
{
    public class Medior
    {
        public void Show()
        {
            People people = new People("张三");
            People people1 = new People("李四");
            people.Connect(people1);
            people1.Connect(people);

            people.Talk("你好");
            people.Talk("早上好张三");

            ChatRoom chatRoom = new ChatRoom("设计模式");
            User user = new User("张山");
            User user1 = new User("李四");
            User user2 = new User("王五");

            user.Login(chatRoom);
            user1.Login(chatRoom);

            user.Talk("你好啊");
        }
    }

    public class People
    {
        private string name;
        private People other;
        public People(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }


        public void Connect(People other)
        {
            this.other = other;
        }

        public void Talk(string msg)
        {
            this.other.Listen(msg);
        }

        public void Listen(string msg)
        {
            Console.WriteLine("对方的声音");
        }
    }


    public class User
    {
        private string name;
        private ChatRoom chatRoom;
        public User(string name)
        {
            this.name = name;
        }
        public string Name { get => name; set => name = value; }
        public void Login(ChatRoom chat)
        {
            this.chatRoom = chat;
            this.chatRoom.Register(this);
        }
        public void Talk(string msg)
        {
            chatRoom.SendMsg(this, msg);
        }
        public void Listen(User user, string msg)
        {
            Console.WriteLine(user.Name, msg);
        }
    }


    public class ChatRoom
    {
        private string name;
        public ChatRoom(string name)
        {
            this.name = name;
        }
        public string Name { get => name; set => name = value; }
        List<User> users = new List<User>();
        public void Register(User user)
        {
            this.users.Add(user);
            Console.WriteLine($"欢迎加入聊天室{user.Name}");
        }
        public void Deregister(User user)
        {
            users.Remove(user);
        }

        public void SendMsg(User fromWhom, string msg)
        {
            this.users.ForEach(toWhom => toWhom.Listen(fromWhom, msg));
        }
    }
}
