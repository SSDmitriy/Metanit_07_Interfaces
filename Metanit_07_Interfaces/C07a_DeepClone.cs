
//https://metanit.com/sharp/tutorial/3.22.php
/*
namespace Metanit_07_Interfaces
{
    internal class C07_ICloneable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("07a - Clone objects with buil-in interface");


            var tom = new Person("Tom", 24, new Company("Microsoft"));
            Person bob = (Person)tom.Clone(); //here is CASTING <Object> --> <Person>
            bob.Work.Name = "noMicrosoft";
            Console.WriteLine("tom's WORK is: " + tom.Work.Name);

        }
    }

    class Person : ICloneable //calss must implement method ICloneable.Clone()
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Company Work { get; set; } //additional complicate field
        public Person(string name, int age, Company company)
        {
            Name = name;
            Age = age;
            Work = company;
        }

        //implement method of interface
        public object Clone()
        {
            return new Person(Name, Age, new Company(Work.Name)); //here is NEW Company
        }

    }

    class Company
    {
        public string Name { get; set; }
        public Company(string name) => Name = name;
    }
}


*/