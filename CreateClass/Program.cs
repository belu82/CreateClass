using System;

namespace CreateClass
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            Person person = new Person("John Doe", 32, Genders.Female);
            Person person1 = new Person("Akárki", 1000, Genders.Male);

            Person person2 = new Person("Slash", 60, Genders.Male);
            
            Console.WriteLine(person);
            Console.WriteLine(person1);
            Console.WriteLine(person2);

        }
    }
}
