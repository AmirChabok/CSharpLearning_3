using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08
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

        public override string ToString()
        {
            return (FullName);
        }

        //		 public override string ToString()
        //		 {
        //		     return(FullName + " " + base.ToString());
        //		 }
    }

    /// <summary>
    /// پیاده سازی اورراید تو استرینگ
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person oPerson = new Person();
            oPerson.Age = 20;
            oPerson.FullName = "Ali Reza Alavi";
            oPerson.ShowInfo();

            System.Console.WriteLine("\n----------");
            System.Console.WriteLine(oPerson);
            System.Console.WriteLine("----------\n");

            System.Console.WriteLine("----------");
            System.Console.WriteLine(oPerson.ToString());
            System.Console.WriteLine("----------\n");

            System.Console.ReadLine();
        }
    }
}
