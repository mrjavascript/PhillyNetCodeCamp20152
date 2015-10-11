using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution_of_Delegates
{
    class Program
    {
        private delegate void MyDelegate(string s);

        private static void Foo(string s)
        {
            Console.WriteLine(s);
        }

        private static void Main(string[] args)
        {
            // C# 1.0
            MyDelegate cs1 = new MyDelegate(Foo);
            cs1(".net 1.0");

            // C# 2.0
            MyDelegate cs2 = delegate(string s) { Console.WriteLine(s); };
            cs2(".net 2.0");

            // C# 3.0
            MyDelegate cs3 = (s) => { Console.WriteLine(s); };
            cs3(".net 3.0");

        Console.Read();


        }
    }
}
