
//https://metanit.com/sharp/tutorial/3.23.php
//sorting of objects in interfaces IComparable, ICompare

// public interfase IComparable
// {
//      int CompareTo(object? o);
// }

/*
namespace Metanit_07_Interfaces
{
    internal class C08_SortIComparable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("08 - Sorting of objects");

            //simple sort
            int[] nums = new int[] { 34, 86, 56, 90, 12 };
            Array.Sort(nums); //Sort() only for primitives, like int, string
            foreach(int i in nums)
            {
                Console.Write($"{i}, ");
            }

            //sorting objects by the Name
            Console.WriteLine("\n\n 01 - Sort by Name");
            var tom = new Person("tom", 42);
            var bob = new Person("bob", 35);
            var sam = new Person("sam", 28);

            Person[] people = new Person[] {tom, bob, sam};
            Array.Sort(people);


            

            foreach(Person person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
            Console.WriteLine("\n");


            var a = new A("aa", 44);
            var b = new A("bb", 33);
            var c = new A("jjj", 22);
            var j = new A("sss",11);
            A[] aa = new A[] { a, b, c, j };
            Array.Sort(aa);
            Console.WriteLine("\n");
            foreach (A item in aa)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }

    class A : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public A(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            A p = (A)obj;
            Console.WriteLine("thisName: " + this.Name + "  p.Name: " + p.Name);
            Console.WriteLine(Age.CompareTo(p.Age));
            return Age.CompareTo(p.Age);

        }

    }

    class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object o) //implementing the interface
        {
            if (o is Person person) return Name.CompareTo(person.Name); //here casting is need 
            else throw new ArgumentException("invalid parameter");
        }
    }


}

*/
