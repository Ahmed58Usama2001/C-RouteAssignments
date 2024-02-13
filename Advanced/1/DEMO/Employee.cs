using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    internal struct Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public static bool operator==(Employee left, Employee right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Employee left, Employee right)
        {
            return !(left.Equals(right));
        }

    }
}
