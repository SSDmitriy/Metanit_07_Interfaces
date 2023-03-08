
//https://metanit.com/sharp/tutorial/3.22.php
/*
namespace Metanit_07_Interfaces
{
    internal class C07_ICloneable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("07 - Clone objects with buil-in interface");


            //Person tom = new Person("Tom", 23);
            //Person bob = tom; // here is copying only references, then they both point to same object
            //bob.Name = "Bob";
            //Console.WriteLine("tom's name is: " + tom.Name);

            var tom = new Person("Tom", 24);
            Person bob = (Person)tom.Clone(); //here is CASTING <Object> --> <Person>
            bob.Name = "BOB";
            Console.WriteLine("tom's name is: " + tom.Name);

        }
    }

    class Person : ICloneable //calss must implement method ICloneable.Clone()
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //implement method of interface
        public object Clone()
        {
            return new Person(Name, Age);
        }

        //another implementation for Clone()
        //public object Clone()
        //{
        //    return MemberwiseClone();
        //}

    }
}

*/