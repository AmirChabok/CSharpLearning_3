using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
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

        public static implicit operator int(Person person)
        {
            return (person.Age);
        }

        public static implicit operator string(Person person)
        {
            return (person.FullName);
        }

        public static explicit operator Person(int age)
        {
            Person oPerson = new Person();

            oPerson.Age = age;

            return (oPerson);
        }

        public static explicit operator Person(string fullName)
        {
            Person oPerson = new Person();

            oPerson.FullName = fullName;

            return (oPerson);
        }
    }

    /// <summary>
    /// پیاده سازی عملیات امپلیسیت و اکسپلیسیت کست برای اشیا و پراپرتی های آنها
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person oPerson1 = new Person();
            oPerson1.Age = 20;
            oPerson1.FullName = "Ali Reza Alavi";

            System.Console.WriteLine("\n----------\n");

            string strTemp1 = oPerson1;
            System.Console.WriteLine("strTemp1: {0}", strTemp1);

            System.Console.WriteLine("\n----------\n");

            string strTemp2 = "Sara Ahmadi";
            Person oPerson2 = (Person)strTemp2;
            oPerson2.ShowInfo();

            System.Console.WriteLine("\n----------\n");

            int intTemp1 = oPerson1;
            System.Console.WriteLine("intTemp1: {0}", intTemp1);

            System.Console.WriteLine("\n----------\n");

            int intTemp2 = 30;
            Person oPerson3 = (Person)intTemp2;
            oPerson3.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
