using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if ((((Person)obj).FullName == FullName) && (((Person)obj).Age == Age))
                return (true);
            else
                return (false);
        }
    }
    /// <summary>
    /// پیاده سازی برابر بودن دو شی
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person oPerson1 = new Person();
            oPerson1.Age = 20;
            oPerson1.FullName = "Ali Reza Alavi";

            Person oPerson2 = new Person();
            oPerson2.Age = 20;
            oPerson2.FullName = "Ali Reza Alavi";

            Person oPerson3 = new Person();
            oPerson3.Age = 30;
            oPerson3.FullName = "Ali Reza Alavi";

            System.Console.WriteLine("\n----------");
            if (oPerson1.Equals(oPerson2))
                System.Console.WriteLine("oPerson1 is equal to oPerson2");
            else
                System.Console.WriteLine("oPerson1 is not equal to oPerson2");
            System.Console.WriteLine("----------");

            System.Console.WriteLine("----------");
            if (oPerson1.Equals(oPerson3))
                System.Console.WriteLine("oPerson1 is equal to oPerson3");
            else
                System.Console.WriteLine("oPerson1 is not equal to oPerson3");
            System.Console.WriteLine("----------\n");

            System.Collections.ArrayList oCollection = new System.Collections.ArrayList();

            oCollection.Add(new Person("Ali Reza Alavi", 20));
            oCollection.Add(new Person("Sara Ahmadi", 30));
            oCollection.Add(new Person("Sanaz Samimi", 40));

            oCollection.Remove(new Person("Ali Reza Alavi", 20));

            foreach (Person oPerson in oCollection)
                oPerson.ShowInfo();

            oCollection.Clear();

            System.Console.ReadLine();
        }
    }
}
