using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
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
            System.Console.WriteLine("I am a person!");
        }
    }

    public class Employee : Person
    {
        public int Salary;

        public Employee()
        {
            System.Console.WriteLine("I am an employee!");
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}, Salary: {2}", FullName, Age, Salary);
        }
    }

    /// <summary>
    /// پیاده سازی سازنده ها
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person oPerson = new Person();

            System.Console.WriteLine("\n----------\n");

            Employee oEmployee = new Employee();

            System.Console.WriteLine("\n----------\n");

            System.Console.ReadLine();
        }
    }
}
