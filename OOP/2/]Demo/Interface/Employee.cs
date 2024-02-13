using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Demo.Interface
{
    public class Employee:ICloneable,IComparable
    {
        public int ID { get; set; }

        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public string? Address { get; set; }

        public Employee(int iD, string? name, decimal salary, string? address)
        {
            ID = iD;
            Name = name;
            Salary = salary;
            Address = address;
        }

        public Employee(Employee employee)
        {
            ID =employee.ID ;
            Name =employee.Name ;
            Salary =employee.Salary ;
            Address =employee.Address ;
        }

        public override string ToString()
        {
            return $"ID = {ID}, Name = {Name}, Salary={Salary}, Address={Address}";
        }

        public object Clone()
        {
            return new Employee(this);
        }

        public  int CompareTo(Object? obj)
        {
            Employee Right = (Employee)obj;

            if (this.Salary < Right.Salary)
                return -1;
            else if (this.Salary > Right.Salary)
                return 1;
            else
                return 0;

        }

    }
}
