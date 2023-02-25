
namespace Metanit_07_Interfaces
{
    internal class C03_ExplicitInterface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("03 - Explicite implemetation fo interface");

            BaseAction baseAction1 = new BaseAction();
            //baseAction1.Move(); //Error. Move() 
            ((IAction)baseAction1).Move(); //unsafe cast
            if (baseAction1 is IAction action) action.Move(); //safe cast

            IAction baseAction2 = new BaseAction();
            baseAction2.Move();


            Console.WriteLine("\n\nClass with implement FEW INTERFACES");
            PersonTwo p2 = new PersonTwo();
            //p2.Study();//Error
            ((ISchool)p2).Study();
            ((IUniversity)p2).Study();



        }

        interface IAction
        {
            void Move();
        }

        class BaseAction : IAction
        {
            void IAction.Move()
            {
                Console.WriteLine("Move in BASE CLASS");
            }
        }


        //two unterfaces for one calss
        interface ISchool
        {
            void Study();
        }
        interface IUniversity
        {
            void Study();
        }

        class Person : ISchool, IUniversity
        {
            public void Study() => Console.WriteLine("Common method for both interfaces");
        }

        class PersonTwo : ISchool, IUniversity
        {
            void ISchool.Study() => Console.WriteLine("Study in SCHOOL");
            void IUniversity.Study() => Console.WriteLine("Study in UNIVERSITY");
        }


        //implemetation properties and other members of interface
        interface IFewFields
        {
            protected internal string Name { get; }
            protected internal void Meth1();
            delegate void FewFieldsHandler();
            protected internal event FewFieldsHandler FewEvents;
        }

        class PersonThree : IFewFields
        {
            string name;

            //explicit implementation of EVENT
            IFewFields.FewFieldsHandler? eventInClass;
            event IFewFields.FewFieldsHandler IFewFields.FewEvents
            {
                add
                {
                    eventInClass += value;
                }

                remove
                {
                    eventInClass -= value;
                }
            }

            //explicit implementation of PROPERTIES
            string IFewFields.Name
            {
                get => name;
            }

            public PersonThree(string name) //constructor
            {
                this.name = name;
            }

            void IFewFields.Meth1()
            {
                Console.WriteLine($"{name} in method1");

            }
        }


    }
}
