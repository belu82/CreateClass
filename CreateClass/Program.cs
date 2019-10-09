using System;

namespace CreateClass
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            Person person = new Person("John Doe",new DateTime(2000,11,11), Genders.Female);
            Person person1 = new Person("Akárki", new DateTime(2001,12,12), Genders.Male);

            Person person2 = new Person("Slash", new DateTime(2002,10,10), Genders.Male);
            
            Console.WriteLine(person);
            Console.WriteLine(person1);
            Console.WriteLine(person2);

        }
    }
}
