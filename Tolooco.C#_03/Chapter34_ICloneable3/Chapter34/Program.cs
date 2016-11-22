using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter34
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

        #region ICloneable Member(s)
        public object Clone()
        {
            return (this.MemberwiseClone());
        }
        #endregion
    }

    public class Factory : System.ICloneable
    {
        public int EmployeeCount;
        public string FactoryName;
        public Person Manager = null;

        public Factory(string factoryName, int employeeCount, string fullName, int age)
        {
            FactoryName = factoryName;
            EmployeeCount = employeeCount;
            Manager = new Person(fullName, age);
        }

        public Factory ShallowCopy()
        {
            return ((Factory)this.MemberwiseClone()); // Wrap
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Factory Name: {0}\nEmployee Count: {1}\nManager Full Name: {2}\nManager Age: {3}", FactoryName, EmployeeCount, Manager.FullName, Manager.Age);
        }

        #region ICloneable Member(s)
        public object Clone()
        {
            Factory oFactory = (Factory)this.MemberwiseClone();
            oFactory.Manager = (Person)this.Manager.Clone();

            return (oFactory);
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            Factory oFactory1 = new Factory("Iran Khodro", 2000, "Ali Reza Alavi", 20);
            Factory oFactory2 = oFactory1.ShallowCopy();
            oFactory2.Manager.Age = 30;
            oFactory2.EmployeeCount = 3000;
            Factory oFactory3 = (Factory)oFactory1.Clone();
            oFactory3.Manager.Age = 40;
            oFactory3.EmployeeCount = 4000;

            System.Console.WriteLine("\n----------");
            oFactory1.ShowInfo();
            System.Console.WriteLine("----------");
            System.Console.WriteLine("\n----------");
            oFactory2.ShowInfo();
            System.Console.WriteLine("----------");
            System.Console.WriteLine("\n----------");
            oFactory3.ShowInfo();
            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }
    }
}
