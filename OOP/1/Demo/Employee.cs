namespace Demo
{
    public struct Employee
    {
        //Encapsulation: Separate data definition (Attributes) from its use (metods)
       private  int employeeId;
        private decimal salary;

        #region Encapsulation using Properties
        //Property: Easy to use like attribute and has the three features of encapsulation

        //1. Full property
        //used when there is a validation needed

        private int age; //backing field

        public int Age
        {
            get { return age; }
            set { age = value>20?value:15; }
        }


        //2. Automatic property
        //Compiler will generate backing field  (Hidden Private attribute)

        public string Address { get; set; }


        //Read Only property

        public decimal Deductions
        {
            get 
            {
                return 0.2M * salary;
            }

            private set { }



        }

        #endregion



        #region Encapsulation using getter and setter
        public int GetEmployeeId()
        {
            return employeeId;
        }

        public void SetEmployeeId(int employeeId)
        {
            this.employeeId = employeeId;   
        }

        public decimal GetEmployeeSalary()
        {
            return salary;
        }

        public void SetEmployeesalary(decimal _salary)
        {
            salary = _salary>5000?3000:2000;
        }
        #endregion

    }
}