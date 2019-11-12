namespace DesignPatterns.Decorator_Homework
{
    internal interface IChatClient
    {
        void Send(Message message);
        Message Receive();
    }
}