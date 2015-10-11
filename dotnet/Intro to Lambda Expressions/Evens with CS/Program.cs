using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evens_with_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            var evens = System.Linq.Enumerable.Range(1, 100).Where(s => s%2 == 0).ToList();
           
            /*
            foreach (int even in evens )
            {
                Console.WriteLine(even);
            }
             * */
            evens.ForEach(s => Console.WriteLine(s));

            Console.Read();

        }
    }
}
