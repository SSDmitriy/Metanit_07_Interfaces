/*
namespace Metanit_07_Interfaces
{
    internal class C06_interfacesLikeGeneric
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("06 - hello");

            Console.WriteLine("\n06a - sending message");

            var myMessenger = new Messenger<Message>(); //create messenger with new object type "Message"
            var message = new Message("text of msg"); //create new message
            myMessenger.Send(message);

            //
            Console.WriteLine("\n\n06b - generic interface");
            IUser<int> user1 = new User<int>(1234); //here is T = int
            Console.WriteLine("User1 ID: " + user1.Id);

            IUser<string> user2 = new User<string>("1212");
            Console.WriteLine("User1 ID: " + user2.Id);

        }
        
    }


    interface IMessage //first inter
    {
        string Text { get; }
    }

    interface IPrintable //second inter
    {
        void Print();
    }

    class Message : IMessage, IPrintable  //class which implemented both of inter
    {
        public string Text { get; }
        public Message(string text)
        {
            Text = text;
        }
        public void Print()
        {
            Console.WriteLine(Text);
        }
    }

    //generic class
    class Messenger<T> where T: IMessage, IPrintable
    {
        public void Send(T message)
        {
            Console.WriteLine("this is sending of message: ");
            message.Print();
        }
    }


    //generic interfaces
    interface IUser<T>
    {
        T Id { get; }
    }

    class User<T>: IUser<T>
    {
        public T Id { get; }
        public User(T id)
        {
            Id = id;
        }
    }
}

*/
