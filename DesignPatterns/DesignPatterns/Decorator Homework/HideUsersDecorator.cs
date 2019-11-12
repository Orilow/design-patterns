using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator_Homework
{
    class HideUsersDecorator : IChatClient
    {
        protected IChatClient _component;

        public HideUsersDecorator(IChatClient component)
        {
            this._component = component;
        }

        public void SetComponent(IChatClient component)
        {
            this._component = component;
        }

        public void Send(Message message)
        {
            message.Author = message.Author.GetHashCode().ToString();
            _component.Send(message);
        }

        public Message Receive()
        {
            return _component.Receive();
        }
    }
}
