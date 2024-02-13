using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    public class Employee
    {
        public int ID { get; set; }

        public string? FullName { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"ID={ID}, FullName={FullName}, Salary={Salary}";
        }

    }
}
