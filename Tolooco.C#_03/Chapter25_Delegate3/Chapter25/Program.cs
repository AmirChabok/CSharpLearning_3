using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter25
{
    /// <summary>
    /// 16 May 2014
    /// Version 1.2.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public delegate void PersonsFeedBack();

    public class Person
    {
        public int Age;
        public string FullName;

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
            System.Console.WriteLine("\n----------");

            PersonsFeedBack oPersonsFeedBack;

            Person oPerson1 = new Person("Ali Reza Alavi", 20);
            oPersonsFeedBack = new PersonsFeedBack(oPerson1.ShowInfo);

            Person oPerson2 = new Person("Sara Ahmadi", 30);

            Person oPerson3 = new Person("Sanaz Samimi", 40);
            oPersonsFeedBack += new PersonsFeedBack(oPerson3.ShowInfo);

            oPersonsFeedBack();

            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }
    }
}
