// https://metanit.com/sharp/tutorial/3.27.php
/*
namespace Metanit_07_Interfaces
{
    internal class C09a_CovariancyInterfaces
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HiHi");

            //CO-variancy
            IMessenger<Message> outlook = new EmailMessenger();
            Message message = outlook.WriteMessage("message for outlook");

            IMessenger<EmailMessage> emailClient = new EmailMessenger();
            IMessenger<Message> messenger = emailClient;
            Message emailMessage = messenger.WriteMessage("it's a emailMessage");
            Console.WriteLine(emailMessage.Text);
        }
    }

    class Message
    {
        public string Text { get; set; }
        public Message(string text)
        {
            Text = text;
        }
    }

    class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text) { }
    }

    interface IMessenger<T> // "out" here means that interface is CO-variancy
    {
        T WriteMessage(string txt);
    }

    class EmailMessenger : IMessenger<EmailMessage>
    {
        public EmailMessage WriteMessage(string txt)
        {
            return new EmailMessage($"Email: {txt}");
        }
    }

}


*/
