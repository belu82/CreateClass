using System;
using System.Collections.Generic;
using System.Text;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public int salary;
        public string profession;
        public Room room;
        public Employee(string name, DateTime age, Genders genders, int salary, string profession, Room room) : base(name, age, genders)
        {
            this.salary = salary;
            this.profession = profession;
            this.room = room;
        }

        public int Salary
        {
            set { salary = value;}
            get { return salary; }
        }
        
        public string Profession
        {
            set { profession = value; }
            get { return profession; }
        }

        public object Clone()
        {
            //return this.MemberwiseClone();
            Employee newEmployee = (Employee)this.MemberwiseClone();
            return newEmployee;
        }
        public override string ToString()
        {
            return "\nEmployee name: " + Name + "\nEmployee salary: " + Salary + "\nRoom: " + room ;
        }
    }
}
