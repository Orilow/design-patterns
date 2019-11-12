using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator_Homework
{
    class Message
    {
        public string Author { get; set; }
        public string Recipient { get; set; }
        public string Text { get; set; }

        public Message(string author, string recipient, string text)
        {
            Author = author;
            Recipient = recipient;
            Text = text;
        }
    }
}
