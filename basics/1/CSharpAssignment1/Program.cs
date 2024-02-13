
namespace CSharpAssignment1
{
    internal class Program
    {
        public class MyClass
        {
            public int Value { get; set; }
        }

        static void Main(string[] args)
        {

            // 1-	Write a program that allows the user to enter a number then print it.

            /*    Console.WriteLine("Please Enter a number: ");
                int x=int.Parse(Console.ReadLine());
                Console.WriteLine("You entered: "+x);*/






            //2-Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen 

            /* Console.WriteLine("Please Enter a non-numeric value: ");
             int  x= int.Parse(Console.ReadLine());
             Console.WriteLine("You entered: " + x);*/
            //gave us an exception because we can't Parse non-numeric value to integer





            //3-Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            /*  Console.WriteLine("Enter the first floating-point number:");
              float num1 = float.Parse(Console.ReadLine());

              Console.WriteLine("Enter the second floating-point number:");
              float num2 = float.Parse(Console.ReadLine());

              float resultAdd = num1 + num2;
              float resultSubtract = num1 - num2;
              float resultMultiply = num1 * num2;
              float resultDivide = num1 / num2;

              Console.WriteLine($"Addition Result: {resultAdd}");
              Console.WriteLine($"Subtraction Result: {resultSubtract}");
              Console.WriteLine($"Multiplication Result: {resultMultiply}");
              Console.WriteLine($"Division Result: {resultDivide}");
            */




            //4-	Write C# program that Extract a substring from a given string.
            /*  Console.Write("Enter the original string: ");
              string originalString = Console.ReadLine();

              Console.Write("Enter the starting index of the substring: ");
              int startIndex = int.Parse(Console.ReadLine());

              Console.Write("Enter the length of the substring: ");
              int length = int.Parse(Console.ReadLine());

              string extractedSubstring = originalString.Substring(startIndex, length);

              Console.WriteLine("Extracted Substring: " + extractedSubstring);*/




            //5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            /*  int x1 = 5;
              int x2 = x1;

              x2+=2;

              Console.WriteLine(x1);
              Console.WriteLine(x2);*/
            //Every variable has different value because value type variable allocate different spaces in memory so when we modify one the other doesn't change





            //6-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            /*  MyClass obj1 = new MyClass();
              obj1.Value = 1;

              MyClass obj2 = obj1;

              obj2.Value = 5;


              Console.WriteLine("obj1.Value: " + obj1.Value); 
              Console.WriteLine("obj2.Value: " + obj2.Value);*/
            // Both obj1 and obj2 now point to the same object in memory so the change will be reflected in both variables



            //7-	Write C# program that take two string variables and print them as one variable 
            /* string firstName, lastName;


             Console.Write("Enter your first name: ");
             firstName = Console.ReadLine();


             Console.Write("Enter your last name: ");
             lastName = Console.ReadLine();

             string fullName = firstName + " " + lastName;
             Console.WriteLine("Your full name is: " + fullName);*/





            //  8 - Which of the following statements is correct about the C#.NET code snippet given below?

            /*   int d;
              d = Convert.ToInt32(!(30 < 20));
              Console.WriteLine(d);   */

            //b)A value 1 will be assigned to d.          -->20 is not greater than 30 -->false -->!false -->true-->toint32(true)-->  1





            //9-	Which of the following is the correct output for the C# code given below?
            /*  Console.WriteLine(13 / 2 + " " + 13 % 2);*/

            //d)	6 1






            //10-What will be the output of the C# code given below?

            /*int num = 1, z = 5;

            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);
            */


            //d)	7 7


        }
    }



}