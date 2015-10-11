using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Sam Bradford");
            Person person2 = new Person("Nick Foles");
            Person person3 = new Person("Alex Smith");
            Person person4 = new Person("Ryan Tanaheil");

            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            // Sort
            // people.Sort(new PersonCompare());
            // people.Sort((s1, s2) => { string.Compare(s1.Name, s2.Name, StringComparison.Ordinal); });



            people = people.OrderBy(x => x.Name).ToList();
            people.ForEach((s) => { Console.WriteLine(s.Name);});

            Console.Read();


        }
    }
}
