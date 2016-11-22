using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
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

        public virtual void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }

    public class Employee : Person
    {
        public int Salary;

        public override void ShowInfo() // Method Overriding!
        {
            // base.ShowInfo (); // Auto!

            System.Console.WriteLine("Full Name: {0}, Age: {1}, Salary: {2}", FullName, Age, Salary);
        }
    }

    /// <summary>
    /// پیاده سازی متد اوررایدینگ
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person oPerson1 = new Person();
            oPerson1.Age = 20;
            oPerson1.FullName = "Ali Reza Alavi";
            oPerson1.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            Employee oEmployee1 = new Employee();
            oEmployee1.Age = 30;
            oEmployee1.FullName = "Sara Ahmadi";
            oEmployee1.Salary = 100000;
            oEmployee1.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            Person oPerson2 = oEmployee1; // Object is important!
            oPerson2.ShowInfo();

            ((Employee)oPerson2).Salary = 200000;

            System.Console.WriteLine("\n----------\n");

            System.Console.ReadLine();
        }
    }
}
