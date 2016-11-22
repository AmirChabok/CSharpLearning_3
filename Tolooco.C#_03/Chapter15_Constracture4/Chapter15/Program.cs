using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15
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

        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }
    }

    public class Employee : Person
    {
        public int Salary;

        // Wrong Usage!
        // public Employee()
        // {
        //     Salary = 120000;
        // }

        // Wrong Usage!
        // public Employee(string fullName, int salary)
        // {
        //     FullName = fullName;
        //     Salary = salary;
        // }

        public Employee(string fullName, int age, int salary)
            : base(fullName, age)
        {
            Salary = salary;
        }

        public Employee()
            : base("", 0)
        {
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
            System.Console.WriteLine("\n----------\n");

            Employee oEmployee1 = new Employee();
            oEmployee1.ShowInfo();

            Employee oEmployee2 = new Employee("Ali Reza Alavi", 20, 20000);
            oEmployee2.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            System.Console.ReadLine();
        }
    }
}
