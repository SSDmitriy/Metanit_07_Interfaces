/*
namespace Metanit_07_Interfaces
{
    internal class C02_usingInterfaces
    {
        static void Main(string[] strings)
        {
            Console.WriteLine("Using interfaces");

            Person person = new Person();
            person.Move();

            Car car = new Car();
            car.Move();


            //call methods with another method 'DoAction()'
            Console.WriteLine("\n\ncall through another");
            DoAction(person);
            DoAction(car);

            //call default
            Console.WriteLine("\n\ncall DEFAULT method");
            //A someObj = new A(); // ERROR because in class 'A' not implemented defMethod()
            // but in IMovable this method exist
            IMovable someObj = new A();
            someObj.defMethod();


        }

        static void DoAction(IMovable movable)
        {
            movable.Move();
        }




    }


    class Person : IMovable  // implement in a CLASS
    {
        public void Move()  //method should be PUBLIC to implement interface
        {
            Console.WriteLine("A Person is moving");
        }
    }

    struct Car : IMovable // implement in STRUCTURE
    {
        public void Move()
        {
            Console.WriteLine("The car is moving");
        }
    }

    class A : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Move in A-class");
        }

        //and here is not implemented another method from IMovable
        // defMethod()
    }
}
*/