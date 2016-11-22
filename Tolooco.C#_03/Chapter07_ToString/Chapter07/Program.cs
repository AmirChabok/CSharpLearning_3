using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
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

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }

    /// <summary>
    /// پیاده سازی متد تو استرینگ
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person oPerson = new Person();
            oPerson.Age = 20;
            oPerson.FullName = "Ali Reza Alavi";
            oPerson.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            System.Console.WriteLine(oPerson); // ToString() method will be called automatically!

            System.Console.WriteLine("\n----------\n");

            System.Console.WriteLine(oPerson.ToString()); // ToString() method shows the object's class name!

            System.Console.WriteLine("\n----------\n");

            System.Console.ReadLine();
        }
    }
}
