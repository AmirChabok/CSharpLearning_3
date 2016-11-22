using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter27
{
    /// <summary>
    /// 16 May 2014
    /// Version 1.2.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public delegate void SystemCallback();

    public interface ICall
    {
        void Call();
    }

    public class SystemCall
    {
        public static void Register(SystemCallback function, int n)
        {
            for (int i = 1; i <= n; i++)
                function();
        }
    }

    public class TestClass : ICall
    {
        public TestClass()
        {
            SystemCall.Register(new SystemCallback(Call), 5);
        }

        public void Call()
        {
            SomeFunction();
        }

        public void SomeFunction()
        {
            System.Console.WriteLine("Function was run by system!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("----------\n");

            TestClass oTestClass = new TestClass();

            System.Console.WriteLine("\n----------");

            System.Console.ReadLine();
        }
    }
}
