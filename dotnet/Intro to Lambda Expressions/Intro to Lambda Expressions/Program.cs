using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = {65, 87, 40, 98, 95, 75, 90};

            // number of passing scores?

            /*
            int numPassing = 0;
            foreach (int score in scores)
            {
                if (score >= 60)
                {
                    numPassing++;
                }
            }
             * */
            int numPassing = scores.Where(s => s > 60).Count();
            // int numPassing = scores.Where(delegate(int s) { })


            Console.WriteLine(numPassing);
            Console.Read();


        }
    }
}
