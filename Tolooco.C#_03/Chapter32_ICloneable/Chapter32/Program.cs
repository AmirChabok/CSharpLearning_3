using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter32
{
    /// <summary>
    /// 16 May 2014
    /// Version 1.2.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public class Person
    {
        public int Age;
        public string FullName;

        public Person()
        {
        }

        public Person(string fullName, int age)
        {
            Age = age;
            FullName = fullName;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person oPerson1 = new Person("Ali Reza Alavi", 20);

            // Wrong Usage!
            // Person oPerson2 = (Person) oPerson1.Copy(); // Creates a new object that is a copy of the current instance!
            // oPerson2.Age = 30;

            System.Console.WriteLine("\n----------");
            oPerson1.ShowInfo();
            System.Console.WriteLine("----------");
            System.Console.WriteLine("\n----------");
            // oPerson2.ShowInfo();
            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }
    }
}
