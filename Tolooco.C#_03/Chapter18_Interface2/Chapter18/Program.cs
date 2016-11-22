using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter18
{
    /// <summary>
    /// 16 May 2014
    /// Version 1.2.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public interface IPerson
    {
        int Age { get; set; }
        string FullName { get; set; }

        void ShowInfo();
        void GetInfo();
        void GetInfo(string fullName, int age);
    }

    /// <summary>
    /// پیاده سازی اینترفیس
    /// </summary>
    public class Person : IPerson
    {
        #region Private Field(s)
        private int _age;
        private string _fullName;
        #endregion

        #region IPerson Members
        public int Age
        {
            get
            {
                return (_age);
            }
            set
            {
                _age = value;
            }
        }

        public string FullName
        {
            get
            {
                return (_fullName);
            }
            set
            {
                _fullName = value;
            }
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("\nFull Name: {0}, Age: {1}\n", _fullName, _age);
        }

        public void GetInfo()
        {
            System.Console.Write("\nFull Name: ");
            _fullName = System.Console.ReadLine();
            System.Console.Write("Age: ");
            _age = System.Convert.ToInt32(System.Console.ReadLine());
        }

        public void GetInfo(string fullName, int age)
        {
            _age = age;
            _fullName = fullName;
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n----------");

            Person oPerson = new Person();
            oPerson.GetInfo();
            oPerson.ShowInfo();

            System.Console.WriteLine("----------");

            System.Console.ReadLine();
        }
    }
}
