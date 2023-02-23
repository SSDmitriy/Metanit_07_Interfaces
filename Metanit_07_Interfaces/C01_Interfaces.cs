namespace Metanit_07_Interfaces
{
    internal class C01_Interfaces
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!")
        }
    }

    //in interface we can describe
    // constants, static variables, methods, properties, delegates, events
    interface IMovable
    {
        const int minSpeed = 0;

        private static int maxSpeed = 60;

        void Move();

        string Name { get; set; }

        delegate void MoveHandler(string mes);

        event MoveHandler MoveEvent;

        //method with default realisation
        void defaultMove()
        {
            Console.WriteLine("in default method in INTERFACE");
        }

        //property with default realisation
        int MaxSpeed { get { return 0; }  }
    }
}