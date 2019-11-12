using DesignPatterns.Decorator_Homework;
using System.Collections.Generic;

namespace DesignPatterns
{
    internal class SimpleChatClient : IChatClient //here could be an abstract class
    {
        public Queue<Message> Messages { get; private set; }  //our chat messages

        public SimpleChatClient()
        {
            Messages = new Queue<Message>();
        }

        public void Send(Message message)
        {
            Messages.Enqueue(message); //sending massage
        }

        public Message Receive()
        {
            return Messages.Dequeue();
        }

    }
}
