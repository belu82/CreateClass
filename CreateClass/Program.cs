using System;

namespace CreateClass
{
    class Person
    {
        public String name;
        public int age;

        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public String Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nAge: " + Age;
        }
    }

    enum Genders
    {
        Male, 
        Femal
    }

    class Program
    {
        public static void Main(string[] args)
        {
           
            Person person = new Person("John Doe", 32);
            Person person1 = new Person("Akárki", 1000);
            Console.WriteLine(person);
            Console.WriteLine(person1);
        }
    }

  
}
