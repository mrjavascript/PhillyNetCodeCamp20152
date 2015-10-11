using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build the expression!
            Expression<Func<int, int, int>> expression = (num1, num2) => num1 + num2;

            // Compile the expression into a function
            Func<int, int, int> myFunc = expression.Compile();

            // Execute!
            int val1, val2;
            Console.Write("Enter num 1: ");
            bool result1 = Int32.TryParse(Console.ReadLine(), out val1);

            Console.Write("Enter num 2: ");
            bool resull2 = Int32.TryParse(Console.ReadLine(), out val2);

            int result = myFunc(val1, val2);

            Console.WriteLine(String.Format("{0} + {1} = {2}", val1, val2, result));
            Console.Read()




        }
    }
}
