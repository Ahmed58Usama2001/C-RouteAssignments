using System;

[Flags]
enum SecurityPrivilege
{
    
    Guest = 1,
    Developer = 2,
    Secretary = 4,
    DBA = 8,
    SecurityOfficer = Guest | Developer | Secretary | DBA
}

class HiringDate
{
    public int Day { get; }
    public int Month { get; }
    public int Year { get; }

    public HiringDate(int day, int month, int year)
    {
        if (!IsValidDate(day, month, year))
        {
            throw new ArgumentException("Invalid hiring date.");
        }

        Day = day;
        Month = month;
        Year = year;
    }

    private bool IsValidDate(int day, int month, int year)
    {
        if (year < 1900 || year > DateTime.Now.Year)
        {
            return false;
        }

        if (month < 1 || month > 12)
        {
            return false;
        }

        if (day < 1 || day > DateTime.DaysInMonth(year, month))
        {
            return false;
        }

        return true;
    }
}

class Employee
{
    public int ID { get; }
    public string Name { get; }
    public SecurityPrivilege SecurityLevel { get; }
    public decimal Salary { get; }
    public HiringDate HireDate { get; }
    public char Gender { get; }

    public Employee(int id, string name, SecurityPrivilege securityLevel, decimal salary, HiringDate hireDate, char gender)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty.");
        }

        if (salary <= 0)
        {
            throw new ArgumentException("Salary must be greater than 0.");
        }

        ID = id;
        Name = name;
        SecurityLevel = securityLevel;
        Salary = salary;
        HireDate = hireDate;

        if (gender == 'M' || gender == 'F')
        {
            Gender = gender;
        }
        else
        {
            throw new ArgumentException("Gender must be 'M' or 'F'.");
        }
    }

    public override string ToString()
    {
        string formattedSalary = string.Format("{0:C}", Salary);
        return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {formattedSalary}, Hire Date: {HireDate.Day}/{HireDate.Month}/{HireDate.Year}, Gender: {Gender}";
    }
}

class Program
{
    static void Main()
    {
        Employee[] EmpArr = new Employee[3];

        try
        {
            EmpArr[0] = new Employee(1, "Ahmed Usama", SecurityPrivilege.DBA, 60000, new HiringDate(5, 8, 2023), 'M');
            EmpArr[1] = new Employee(2, "Nashwa Zahra", SecurityPrivilege.Guest, 40000, new HiringDate(15, 7, 2021), 'F');
            EmpArr[2] = new Employee(3, "Ali Ashraf", SecurityPrivilege.SecurityOfficer, 90000, new HiringDate(10, 3, 2022), 'M');
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
            return;
        }

        Array.Sort(EmpArr, (e1, e2) => e1.HireDate.Year.CompareTo(e2.HireDate.Year));

        Console.WriteLine("Sorted Employees:");
        foreach (var emp in EmpArr)
        {
            Console.WriteLine(emp);
        }
    }
}
