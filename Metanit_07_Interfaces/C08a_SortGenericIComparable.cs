/*

namespace Metanit_07_Interfaces
{
    internal class C08a_SortGenericIComparable
    {

        static void Main(string[] strings)
        {
            //sorting objects by the Name
            Console.WriteLine("\n\n 08a - Sort by Name");
            var tom = new Person("tom", 42);
            var bob = new Person("bob", 35);
            var sam = new Person("sam", 28);

            Person[] people = new Person[] { tom, bob, sam };
            Array.Sort(people);




            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
            //Console.WriteLine("\n");

        }
    }




    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person p) //implementing the interface
        {
            return Age.CompareTo(p.Age);
        }
    }
}
*/