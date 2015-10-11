using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Sort
{
    class PersonCompare : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }
    }
}
