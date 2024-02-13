using System.Collections;

namespace DEMO;

internal class program
{
    static void Main()
    {

        #region Non - generic swap

        //int A = 10, B = 20;
        //Console.WriteLine(A+"   "+B);
        //Helper.Swap(ref A,ref B);
        //Console.WriteLine(A + "   " + B);

        //double A = 10.6, B = 20.8;
        //Console.WriteLine(A + "   " + B);
        //Helper.Swap(ref A, ref B);
        //Console.WriteLine(A + "   " + B);

        //string A = "Ahmed", B ="Hossam";
        //Console.WriteLine(A + "   " + B);
        //Helper.Swap(ref A, ref B);
        //Console.WriteLine(A + "   " + B);
        #endregion



        #region generic swap
        //generic method: not generic class or struct ot interface
        //compiler will detect the datatype of T from input parameters

        //int A = 10, B = 20;
        //Console.WriteLine(A+"   "+B);
        //Helper.Swap(ref A,ref B);
        //Console.WriteLine(A + "   " + B);

        //double A = 10.6, B = 20.8;
        //Console.WriteLine(A + "   " + B);
        //Helper.Swap(ref A, ref B);
        //Console.WriteLine(A + "   " + B);

        //string A = "Ahmed", B ="Hossam";
        //Console.WriteLine(A + "   " + B);
        //Helper.Swap(ref A, ref B);
        //Console.WriteLine(A + "   " + B);




        #endregion


        #region generic search

        //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        //Console.WriteLine(Helper<int>.SearchArray(numbers, 4));


        //Employee employee1 = new Employee
        //{
        //    ID = 1,
        //    Name = "Ahmed"
        //};
        //Employee employee2 = new Employee
        //{
        //    ID = 2,
        //    Name = "Omar"
        //};
        //Employee employee3 = new Employee
        //{
        //    ID = 3,
        //    Name = "Ali"
        //};

        //Employee[] employees = new Employee[] { employee1, employee2, employee3 };

        //Console.WriteLine(Helper<Employee>.SearchArray(employees, employee3));

        #endregion


        #region non generic collection Arraylist

        ArrayList arrayList = new ArrayList();

        Console.WriteLine($"Initial Capacity: {arrayList.Capacity}"); 

        arrayList.Add(42);
        arrayList.Add("Hello");
        arrayList.Add(DateTime.Now);

        Console.WriteLine($"Count: {arrayList.Count}");
        Console.WriteLine($"Capacity: {arrayList.Capacity}");

        arrayList.Add("New Element");
        arrayList.Add(123);

        Console.WriteLine($"Count: {arrayList.Count}"); 
        Console.WriteLine($"Capacity: {arrayList.Capacity}"); 

        arrayList.TrimToSize();

        Console.WriteLine($"Count: {arrayList.Count}"); 
        Console.WriteLine($"Capacity after TrimToSize: {arrayList.Capacity}");

        #endregion



        #region generic collection list

        List<int> intList = new List<int>();

        Console.WriteLine($"Initial Capacity: {intList.Capacity}"); 

        intList.Add(42);
        intList.Add(100);
        intList.Add(7);

        Console.WriteLine($"Count: {intList.Count}");
        Console.WriteLine($"Capacity: {intList.Capacity}"); 

        intList.Add(123);
        intList.Add(456);

        Console.WriteLine($"Count: {intList.Count}"); 
        Console.WriteLine($"Capacity: {intList.Capacity}"); 

        intList.TrimExcess();

        Console.WriteLine($"Count: {intList.Count}");
        Console.WriteLine($"Capacity after TrimExcess: {intList.Capacity}");

        #endregion

        #region HashTables==>Dictionary
        Dictionary<string, int> ageDictionary = new Dictionary<string, int>();

        ageDictionary.Add("Alice", 25);
        ageDictionary.Add("Bob", 30);
        ageDictionary.Add("Carol", 28);

      

        int aliceAge = ageDictionary["Alice"];
        int bobAge = ageDictionary["Bob"];

        Console.WriteLine($"Alice's Age: {aliceAge}"); 
        Console.WriteLine($"Bob's Age: {bobAge}"); 

        if (ageDictionary.TryGetValue("Dave", out int daveAge))
        {
            Console.WriteLine($"Dave's Age: {daveAge}");
        }
        else
        {
            Console.WriteLine("Dave's age not found.");
        }

        if (ageDictionary.ContainsKey("Alice"))
        {
            ageDictionary["Alice"] = 26;
            Console.WriteLine("Updated Alice's age.");
        }

        if (ageDictionary.TryGetValue("Alice", out int updatedAliceAge))
        {
            Console.WriteLine($"Updated Alice's Age: {updatedAliceAge}");
        }
        else
        {
            Console.WriteLine("Updated Alice's age not found.");
        }


        #endregion


    }

}