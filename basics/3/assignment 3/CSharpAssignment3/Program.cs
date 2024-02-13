namespace CSharpAssignment3;


class Person
{
    public string Name { get; set; }
}
internal class Program
{
    //1
    void ModifyValue(int num)
    {
        num = 10; 
        Console.WriteLine("Inside the method: " + num);
    }

    static void ModifyValue(ref int num)
    {
        num = 10; 
        Console.WriteLine("Inside the method: " + num);
    }



    //2
    static void ModifyPerson(Person person)
    {
        person.Name = "Omar";
        person = new Person { Name = "Ali" }; 
    }


    static void ModifyPersonByRef(ref Person person)
    {
        person.Name = "Omar"; 
        person = new Person { Name = "Ali" }; 
    }


    //3
    public static void SumAndSubtract(int num1, int num2, int num3, int num4, out int sum, out int subtract)
    {
        sum = num1 + num2;
        subtract = num3 - num4;
    }


    //4
    public static int SumOfDigits(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        return sum;
    }

    //5
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        if (number == 2 || number == 3)
            return true;

        if (number % 2 == 0)
            return false;

        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    //6
    static void MinMaxArray(int[] arr, ref int minVal, ref int maxVal)
    {
        if (arr.Length == 0)
        {
            Console.WriteLine("Error: Array is empty.");
            return;
        }

        minVal = maxVal = arr[0];

       
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < minVal)
            {
                minVal = arr[i];
            }
            if (arr[i] > maxVal)
            {
                maxVal = arr[i]; 
            }
        }
    }


    //7
    static long Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Number must be non-negative.");
        }

        long result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }


    //8
    static string ChangeChar(string input, int position, char newChar)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Input string cannot be null or empty.");
        }

        if (position < 0 || position >= input.Length)
        {
            throw new ArgumentOutOfRangeException("position", "Position is out of range.");
        }

        char[] charArray = input.ToCharArray();
        charArray[position] = newChar;
        return new string(charArray);
    }


    static void Main (string [] args)
    {

        //1

        //  Passing by Value:
        // When you pass a value type parameter by value,
        // a copy of the parameter's value is passed to the method.
        // Any changes made to the parameter within the method do not affect the original value of the variable in the calling code.

        /*int numValue = 5;
        Console.WriteLine("Before calling method: " + numValue);
        ModifyValue(numValue);
        Console.WriteLine("After calling method: " + numValue);*/


        //Passing by Reference:
        //  When you pass a value type parameter by reference,
        //  the method receives the memory address(reference) of the parameter rather than a copy of its value.
        //  Any changes made to the parameter within the method will affect the original value of the variable in the calling code.

        /*  int numValue = 5;
          Console.WriteLine("Before calling method: " + numValue);
          ModifyValue(ref numValue);
          Console.WriteLine("After calling method: " + numValue);*/


        //------------------------------------------------------------

        //2

        //Passing by Value:
        // When you pass a reference type parameter by value,
        // a copy of the reference is passed to the method.
        // This means that the method can access and modify the properties and fields of the object,
        // but if the reference itself is modified to point to a new object,
        // it won't affect the original reference outside the method.

        /*
        Person personValue = new Person { Name = "Ahmed" };
        Console.WriteLine("Before calling method: " + personValue.Name); //Ahmed

        ModifyPerson(personValue);
        Console.WriteLine("After calling method: " + personValue.Name); //Omar
        */


        //Passing by Reference:
        //When you pass a reference type parameter by reference,
        //the method receives the memory address(reference) of the reference type object rather than a copy of the reference.
        //This allows the method to modify both the content of the object and the reference itself,
        //which will also affect the original reference outside the method.


        /*
        Person personValue = new Person { Name = "Ahmed" };
        Console.WriteLine("Before calling method: " + personValue.Name); //Ahmed

        ModifyPerson(personValue);
        Console.WriteLine("After calling method: " + personValue.Name); //Ali
        */

        //---------------------------------------------------------------------------------------

        //3
        /*
                Console.WriteLine("Enter four numbers:");

                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int num3 = int.Parse(Console.ReadLine());
                int num4 = int.Parse(Console.ReadLine());

                int sum, subtract;


                SumAndSubtract(num1, num2, num3, num4, out sum, out subtract);

                Console.WriteLine("Sum of the first two numbers: " + sum);
                Console.WriteLine("Subtraction of the last two numbers: " + subtract);
        */

        //-----------------------------------------------------------------------------------

        //4
        /*
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                int sum = SumOfDigits(num);

                Console.WriteLine("The sum of the digits of the number " + num + " is: " + sum);
        */

        //----------------------------------------------------------------------------------

        //5
        /* Console.Write("Enter a number: ");
         int num = int.Parse(Console.ReadLine());

         bool isPrime = IsPrime(num);

         if (isPrime)
             Console.WriteLine(num + " is a prime number.");
         else
             Console.WriteLine(num + " is not a prime number.");
        */


        //-----------------------------------------------------------------------------------

        //6
        /*  int[] numbers = { 10, 5, 25, 15, 30, 20 };
          int minValue = 0;
          int maxValue = 0;

          MinMaxArray(numbers, ref minValue, ref maxValue);

          Console.WriteLine("Minimum value: " + minValue);
          Console.WriteLine("Maximum value: " + maxValue);

          */

        //------------------------------------------------------------------------------------

        //7

        /* Console.Write("Enter a non-negative integer: ");
         if (int.TryParse(Console.ReadLine(), out int num))
         {
             try
             {
                 long factorial = Factorial(num);
                 Console.WriteLine($"Factorial of {num} is: {factorial}");
             }
             catch (ArgumentException ex)
             {
                 Console.WriteLine($"Error: {ex.Message}");
             }
         }
         else
         {
             Console.WriteLine("Invalid input. Please enter a valid non-negative integer.");
         }
        */

        //---------------------------------------------------------------------------------

        //8
/*
        try
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter the position (0 based): ");
            if (int.TryParse(Console.ReadLine(), out int position))
            {
                Console.Write("Enter the new character: ");
                char newChar = Console.ReadKey().KeyChar;

                string result = ChangeChar(input, position, newChar);
                Console.WriteLine($"\nResult: {result}");
            }
            else
            {
                Console.WriteLine("Invalid position input.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
      */
    }

}
