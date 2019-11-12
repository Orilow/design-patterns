using DesignPatterns.Decorator_Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new SimpleChatClient();
            var hided = new HideUsersDecorator(client);
            var encrypted = new EncryptedDecorator(hided);

            var message = new Message("Luke", "Ilya", "Hello world!");
            encrypted.Send(message);

            Console.WriteLine(client.Messages.First().Author);
            Console.WriteLine(client.Messages.First().Text);

            var res = encrypted.Receive();
            Console.WriteLine(res.Author);
            Console.WriteLine(res.Text);
            Console.ReadKey();
        }
    }
}
