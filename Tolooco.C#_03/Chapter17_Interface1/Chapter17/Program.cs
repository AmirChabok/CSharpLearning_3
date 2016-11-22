using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17
{
    /// <summary>
    /// 16 May 2014
    /// Version 1.2.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    /// Interface:
    ///   1- [interface] is a perfect abstract class.
    ///   2- You should inherit a [interface] from the other [interface].
    ///   3- You should not inherit a [interface] from a [class].
    ///   4- You should inherit a [class] from zero/one [class] and/or one/many [interface].
    ///   5- [interface] does not have any filed(s).
    ///   6- [interface] does not hava any event(s).
    ///   7- [interface] does not hava any constructor.
    ///   8- [interface] members does not have any access modifiyers (public, private, protected...).
    /// </summary>
    public interface IPerson
    {
        #region Member(s)
        #region Property(ies)
        int Age { get; set; }
        string FullName { get; set; }
        #endregion

        #region Method(s)
        void ShowInfo();
        void GetInfo();
        void GetInfo(string fullName, int age);
        #endregion
        #endregion
    }

    /// <summary>
    /// پیاده سازی اینترفیس
    /// </summary>
    public class Person : IPerson
    {
        #region IPerson Members
        public int Age
        {
            get
            {
                // TODO:  Add Person.Age getter implementation
                return 0;
            }
            set
            {
                // TODO:  Add Person.Age setter implementation
            }
        }

        public string FullName
        {
            get
            {
                // TODO:  Add Person.FullName getter implementation
                return null;
            }
            set
            {
                // TODO:  Add Person.FullName setter implementation
            }
        }

        public void ShowInfo()
        {
            // TODO:  Add Person.ShowInfo implementation
        }

        public void GetInfo()
        {
            // TODO:  Add Person.GetInfo implementation
        }

        public void GetInfo(string fullName, int age)
        {
            // TODO:  Add Person.DT_CSHARP_LEARNING.IPerson.GetInfo implementation
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n----------");

            System.Console.ReadLine();
        }

    }
}
