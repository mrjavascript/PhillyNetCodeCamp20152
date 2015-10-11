using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Sort
{
    class Person
    {
        public string Name { get; set; }
        public int age { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

    }
}
