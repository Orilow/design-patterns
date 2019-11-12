using DesignPatterns.Decorator_Homework;

namespace DesignPatterns
{
    internal class EncryptedDecorator : IChatClient
    {
        private IChatClient _component;

        public EncryptedDecorator(IChatClient component)
        {
            this._component = component;
        }

        public Message Receive()
        {
            var mes = _component.Receive();
            mes.Text = mes.Text.Substring(0, mes.Text.Length - "</encrypted>".Length);
            mes.Text = mes.Text.Substring("<encrypted>".Length, mes.Text.Length - "<encrypted>".Length);
            return mes;
        }

        public void Send(Message message)
        {
            message.Text = "<encrypted>" + message.Text + "</encrypted>";
            _component.Send(message);
        }
    }
}