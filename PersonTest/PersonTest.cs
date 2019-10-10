using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CreateClass;


namespace PersonTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int room = 1;
            Room room1 = new Room(room);

            String name = "Wilson";
            DateTime date = new DateTime(2000, 11, 11);

            Person person = new Person(name, date, Genders.Male);        
            
        }
    }
}
