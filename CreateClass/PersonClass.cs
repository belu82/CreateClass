using System;
using System.Collections.Generic;
using System.Text;

namespace CreateClass
{
    class Person
    {
        public String name;
        public int age;
        public Genders genders;

        public Person (String name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person(String name, int age, Genders genders)
        {
            this.name = name;
            this.age = age;
            this.genders = genders;
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
            return "Name: " + Name + " Age: " + Age + " Gender: " + genders;
        
        }

   
    }

}
