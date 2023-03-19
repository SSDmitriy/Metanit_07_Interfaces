using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metanit_07_Interfaces
{
    internal class C09b_ContravariancyInterfaces
    {
        static void Main(string[] args)
        {
            Console.WriteLine("contravariance");

            IMessenger<EmailMessage> outlook = new SimpleMessenger();
            outlook.SendMessage(new EmailMessage("Hi via outlook"));

            IMessenger<Message> telegram = new SimpleMessenger();
            IMessenger<EmailMessage> emailClient = telegram;
            emailClient.SendMessage(new EmailMessage("helllllooooo"));
        }
    }

    class Message
    {
        public string Text { get; set; }
        public Message(string text) => Text = text;
    }
    class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text) { }
    }

    interface IMessenger<in T> // "in" here for CONTRAvariance
    {
        void SendMessage(T message);
    }

    class SimpleMessenger : IMessenger<Message>
    {
        public  void SendMessage(Message message)
        {
            Console.WriteLine($"send via simpleMessenger: " + message);
        }
    }
}
