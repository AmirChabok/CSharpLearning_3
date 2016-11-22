using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter33
{
    /// <summary>
    /// 16 May 2014
    /// Version 1.2.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public class Person : System.ICloneable
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

        public Person Copy()
        {
            return ((Person)this.MemberwiseClone());
        }

        #region ICloneable Members
        public object Clone()
        {
            return (this.MemberwiseClone());
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person oPerson1 = new Person("Ali Reza Alavi", 20);
            Person oPerson2 = (Person)oPerson1.Clone();
            oPerson2.Age = 30;

            Person oPerson3 = oPerson1.Copy();

            System.Console.WriteLine("\n----------");
            oPerson1.ShowInfo();
            System.Console.WriteLine("----------");
            System.Console.WriteLine("\n----------");
            oPerson2.ShowInfo();
            System.Console.WriteLine("----------");
            oPerson3.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
