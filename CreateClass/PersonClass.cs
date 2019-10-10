using System;
using System.Collections.Generic;
using System.Text;

namespace CreateClass
{
    public class Person
    {
        public String name;
        public DateTime age;
        public Genders genders;

      
        public Person(String name, DateTime age, Genders genders)
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

        public DateTime Age
        {
            set { age = value; }
            get { return age; }
        }

        public override string ToString()
        {
            return "Name: " + Name + "Age: " + Age + "Gender: " + genders;
        }

   
    }

}
