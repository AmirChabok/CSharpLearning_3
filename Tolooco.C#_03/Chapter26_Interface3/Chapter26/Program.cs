using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter26
{
    /// <summary>
    /// 16 May 2014
    /// Version 1.2.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public interface ICall
    {
        void Call();
    }

    public class SystemCall
    {
        public static void Register(ICall sender, int n)
        {
            for (int i = 1; i <= n; i++)
                sender.Call();
        }
    }

    public class TestClass : ICall
    {
        public TestClass()
        {
            SystemCall.Register(this, 5);
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
