using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter24
{
    /// <summary>
    /// 16 May 2014
    /// Version 1.2.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public delegate void MyDelegate();

    public class MyClass
    {
        public static void a()
        {
            System.Console.WriteLine("(a) method was run!");
        }

        public void b()
        {
            System.Console.WriteLine("(b) method was run!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n----------");

            MyDelegate oMyDelegate1;
            oMyDelegate1 = new MyDelegate(MyClass.a);
            oMyDelegate1();

            System.Console.WriteLine("\n----------");

            MyClass oMyClass1 = new MyClass();
            MyDelegate oMyDelegate2;
            oMyDelegate2 = new MyDelegate(oMyClass1.b);
            oMyDelegate2();

            System.Console.WriteLine("\n----------");

            MyDelegate oMyDelegate3;
            oMyDelegate3 = oMyDelegate1 + oMyDelegate2;
            oMyDelegate3();

            System.Console.WriteLine("\n----------");

            MyDelegate oMyDelegate4;
            oMyDelegate4 = oMyDelegate3 - oMyDelegate2;
            oMyDelegate4();

            System.Console.WriteLine("\n----------");

            System.Console.ReadLine();
        }
    }
}
