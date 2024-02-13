using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}";
        }

        public static implicit operator Person (Employee employee)
        {
            string[] names=employee.FullName.Split(" ");
            return new Person { FirstName = names[0], LastName = names[names.Length-1] };
        }

    }
}
