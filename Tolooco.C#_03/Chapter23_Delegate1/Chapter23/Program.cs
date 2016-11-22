using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter23
{
    /// <summary>
    /// 16 May 2014
    /// Version 1.2.1
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    // Delegate is a class that it's instances call the others methods!
    // You should define Delegate in your namespace!
    public delegate void MyDelegate(int n); // First step: Define your Delegate class!

    public class MyClass
    {
        public static void a(int x)
        {
            System.Console.WriteLine("(a) method was run with {0} value!", x);
        }

        public void b(int y)
        {
            System.Console.WriteLine("(b) method was run with {0} value!", y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n----------");

            MyDelegate oMyDelegate1; // Second Step: Define your Delegate instance!
            oMyDelegate1 = new MyDelegate(MyClass.a); // Third Step: Register some method for your Delegate instance!
            oMyDelegate1(5); // Forth Step: Call your Delegate object!

            System.Console.WriteLine("\n----------");

            MyClass oMyClass1 = new MyClass();
            oMyDelegate1 = new MyDelegate(oMyClass1.b);
            oMyDelegate1(10);

            System.Console.WriteLine("\n----------");

            MyDelegate oMyDelegate2; // Second Step: Define your Delegate instance!

            oMyDelegate2 = new MyDelegate(MyClass.a); // Third Step: Register some method for your Delegate instance!

            MyClass oMyClass2 = new MyClass();
            MyClass oMyClass3 = new MyClass();
            MyClass oMyClass4 = new MyClass();

            oMyDelegate2 += new MyDelegate(oMyClass2.b);
            oMyDelegate2 += new MyDelegate(oMyClass4.b);

            oMyDelegate2(5); // Forth Step: Call your Delegate object!

            System.Console.ReadLine();
        }
    }
}
