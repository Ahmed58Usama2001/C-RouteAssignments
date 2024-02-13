using System;


namespace Demo
{
    class Program
    {
        static void Main()
        {

            #region Struct with Encapsulation
            Employee employee = new Employee();

            //employee.EmployeeId;

            Console.WriteLine(employee.GetEmployeeId()); // 0 because of default constructor

            employee.SetEmployeeId(10);
            Console.WriteLine(employee.GetEmployeeId()); //10

            employee.Age = 22;
            Console.WriteLine(employee.Age); //2


            employee.Address = "Tanta";
            Console.WriteLine(employee.Address);

            #endregion



        }
    }
}