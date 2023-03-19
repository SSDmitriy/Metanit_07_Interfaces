
//public interface IComparer<in T>
//{
//    int Compare(T? x, T? y);
//}

/*
using System.Collections;

namespace Metanit_07_Interfaces
{
    internal class C08b_IComparer
    {

        static void Main(string[] args)
        {
            Console.WriteLine("08b - IComparer for compare two objects");

            Person alice = new Person("Alice", 23);
            Person bob = new Person("Bob", 35);
            Person kate = new Person("Kate", 46);

            Person[] pers =  { alice, bob, kate };
            PersComparer persComparer = new PersComparer(); // instance of Comparer
            Array.Sort(pers, persComparer); //here is NEED TWO arguments to method Sort()
                                            // firs - COLLECTION, second - COMPARER (like a rule to compare)
                                

            foreach(Person p in pers)
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }

        }
    }


    class Person
    {
        public string Name { get; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class PersComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            return p1.Name.Length - p2.Name.Length; //compare by name's legth
        }
    }
}

*/