//https://metanit.com/sharp/tutorial/3.48.php
/*
namespace Metanit_07_Interfaces
{
    internal class C05_InheritanceOfInterfaces
    {
        static void Main(string[] args)
        {
            Console.WriteLine("05 - Inheritance of interfacces");

            Console.WriteLine("\n\n1 - just call meth from base class");
            IRunAction ob1 = new BaseAction();
            ob1.Run();
            ob1.Move();


            Console.WriteLine("\n\n2 - shadoeing method");
            IAction_2 ia2 = new BaseClass_2();
            ia2.Move_2();

            IRunAction_2 ia3 = new BaseClass_2();
            ia3.Move_2();
            

        }


        // IAction : IRunAction : BaseAction(class)
        interface IAction
        {
            void Move()
            {

            }
        }

        interface IRunAction : IAction //inheritance of IAction
        {
            void Run()
            {

            }
        }

        class BaseAction : IRunAction //implemented only one interface, but should implement both methods
        {
            public void Move()
            {
                Console.WriteLine("method for moving");
            }

            public void Run()
            {
                Console.WriteLine("meth for run");
            }
        }

        //shadowing of method from interface
        interface IAction_2
        {
            void Move_2()
            {
                Console.WriteLine("Default Move_2 in interface IAction");
            }
        }

        interface IRunAction_2 : IAction_2
        {
            new void Move_2()
            {
                Console.WriteLine("shadoving for method Move_2 in IRunAction");
            }
        }

        class BaseClass_2 : IRunAction_2
        {

        }

    }
}

*/