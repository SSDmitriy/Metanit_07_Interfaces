

namespace Metanit_07_Interfaces
{
    internal class C04_interfacesInChildClasses
    {
        static void Main(string[] strings)
        {
            Console.WriteLine("04 - implemented interfaces in basic classes and interfaces");


            Console.WriteLine("\n\n00a- Meth in base class");
            IAction action = new HeroAction();
            action.Move();

            Console.WriteLine("\n\n01- Overriding virtual method");
            IAction_1 iaction_1 = new HeroAction_1();
            iaction_1.Move_1();
            BaseAction_1 action_1 = new HeroAction_1();
            action_1.Move_1();
            HeroAction_1 haction_1 = new HeroAction_1();
            haction_1.Move_1();


            Console.WriteLine("\n\n02- Shadowing method in child calss");
            IAction_2 iaction_2 = new HeroAction_2();
            iaction_2.Move_2();
            BaseAction_2 action_2 = new HeroAction_2();
            action_2.Move_2();
            HeroAction_2 haction_2 = new HeroAction_2();
            haction_2.Move_2();


            Console.WriteLine("\n\n03- Second realising");
            IAction_3 iaction_3 = new HeroAction_3();
            iaction_3.Move_3(); // in Hero...
            BaseAction_3 action_3 = new HeroAction_3();
            action_3.Move_3(); // in Base...
            HeroAction_3 haction_3 = new HeroAction_3();
            haction_3.Move_3(); // in Hero...


            Console.WriteLine("\n\n04- Explicit realising interface");
            IAction_4 iaction_4 = new HeroAction_4();
            iaction_4.Move_4(); // in IAction...
            BaseAction_4 action_4 = new HeroAction_4();
            action_4.Move_4(); // in Base...
            HeroAction_4 haction_4 = new HeroAction_4();
            haction_4.Move_4(); // in Hero...


        }


    }


    //00- interface -> abstract class -> class
    interface Imovable
    {
        void Move();
    }

    abstract class Person : Imovable
    {
        public abstract void Move();
    }

    class Driver : Person
    {
        public override void Move()
        {
            Console.WriteLine("Driver in car");
        }
    }


    //00a- inheritance from interface AND base class
    interface IAction
    {
        void Move();
    }

    class BaseClass
    {
        public void Move()
        {
            Console.WriteLine("in BASE class");
        }
    }

    class HeroAction : BaseClass, IAction //inherit from both: base class and interface
    {

    }


    //01- overriding abstract methods
    interface IAction_1
    {
        void Move_1();
    }

    class BaseAction_1 : IAction_1
    {
        public virtual void Move_1() // VIRTUAL for overriding
        {
            Console.WriteLine("Move In BaseAction");
        }
    }

    class HeroAction_1 : BaseAction_1
    {
        public override void Move_1() // OVERRIDE!
        {
            Console.WriteLine("Move In HEROAction");
        }
    }


    //02- shadowing method in child class
    interface IAction_2
    {
        void Move_2();
    }

    class BaseAction_2 : IAction_2
    {
        public void Move_2()
        {
            Console.WriteLine("Move() in BaseAction_2");
        }
    }

    class HeroAction_2 : BaseAction_2 // inheritance only from BaseAction
    {
        public new void Move_2() //new! ?
        {
            Console.WriteLine("Move() in HeroAction_2");
        }
    }


    //03- second realisation in child class
    interface IAction_3
    {
        void Move_3();
    }

    class BaseAction_3 : IAction_3
    {
        public void Move_3()
        {
            Console.WriteLine("Move() in BaseAction_3");
        }
    }

    class HeroAction_3 : BaseAction_3, IAction_3 // inheritance from BOTH BaseAction AND interface
    {
        public new void Move_3() //new! ?
        {
            Console.WriteLine("Move() in HeroAction_3");
        }
    }


    //04- Explicit implementing interface in child class
    interface IAction_4
    {
        void Move_4();
    }

    class BaseAction_4 : IAction_4
    {
        public void Move_4()
        {
            Console.WriteLine("Move() in BaseAction_4");
        }
    }

    class HeroAction_4 : BaseAction_4, IAction_4 // inheritance from BOTH BaseAction AND interface
    {
        public new void Move_4() //new! ?
        {
            Console.WriteLine("Move() in HeroAction_4");
        }

        void IAction_4.Move_4() //EXPLICIT realisation interface
        {
            Console.WriteLine("Move() in IAction_4");

        }
    }

}
