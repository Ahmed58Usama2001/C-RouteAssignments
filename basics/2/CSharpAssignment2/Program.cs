using System.Text;

namespace CSharpAssignment2
{
    internal class Program
    {

        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }


        static string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
            {
                return "0";
            }

            string binary = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binary = remainder + binary;
                decimalNumber /= 2;
            }

            return binary;
        }

        static string GetEfficiencyLevel(double timeTaken)
        {
            if (timeTaken >= 2 && timeTaken <= 3)
            {
                return "Highly Efficient";
            }
            else if (timeTaken > 3 && timeTaken <= 4)
            {
                return "Increase Speed";
            }
            else if (timeTaken > 4 && timeTaken <= 5)
            {
                return "Training Required";
            }
            else if (timeTaken > 5)
            {
                return "Required to Leave Company";
            }
            else
            {
                return "Invalid Time";
            }
        }


        static void Main(string[] args)
        {

            //1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            /* int num=int.Parse(Console.ReadLine());
             if(num % 3 == 0 && num % 4 == 0)
                 Console.WriteLine("Yes");
             else
              Console.WriteLine("No"); */


            //2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            /*  int num = int.Parse(Console.ReadLine());
              if (num <0)
                  Console.WriteLine("Negative");
              else
                  Console.WriteLine("Positive");*/


            //3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            /*  int[] numbers = new int[3];

              for (int i = 0; i < 3; i++)
                 numbers[i] = int.Parse(Console.ReadLine());


              int max = numbers[0];
              int min = numbers[0];

              for (int i = 1; i < 3; i++)
              {
                  if (numbers[i] > max)
                      max = numbers[i];

                  if (numbers[i] < min)
                      min = numbers[i];
              }

              Console.WriteLine($"Max element: {max}");
              Console.WriteLine($"Min element: {min}");*/


            //4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            /* int num = int.Parse(Console.ReadLine());
             if (num % 2 == 0)
                 Console.WriteLine("Even number");
             else
                 Console.WriteLine("Odd number");*/



            //5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            /* 
             char inputChar = char.ToLower(Console.ReadKey().KeyChar); 

             if (inputChar == 'a' || inputChar == 'e' || inputChar == 'i' || inputChar == 'o' || inputChar == 'u')
                 Console.WriteLine("vowel");
             else
                 Console.WriteLine("consonant");*/


            //6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            /*   int num = int.Parse(Console.ReadLine());
              for (int i = 1; i <= num; i++)
                  Console.WriteLine(i);*/



            //7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            /*  int num = int.Parse(Console.ReadLine());
              for(int i = 1; i <=12; i++)
                  Console.WriteLine(i*num);*/



            //8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            /*int num = int.Parse(Console.ReadLine());

           for(int i = 2; i <= num; i+=2)
               Console.WriteLine(i);*/


            //9- Write a program that takes two integers then prints the power.

            /*  int num = int.Parse(Console.ReadLine());
              int power = int.Parse(Console.ReadLine());
              int result = 1;

              for(int i = 1; i <= power; i++)
                  result = result * num;

              Console.WriteLine(result);*/


            //10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            /* int[] marks = new int[5];
             int total = 0,average,percentage;

             Console.WriteLine("Enter Marks of five subjects: ");

             for (int i = 0; i < 5; i++)
             { marks[i] = int.Parse(Console.ReadLine());
             total+=marks[i];
             }


             average = total / marks.Length;
             percentage = (total * 100) / (marks.Length * 100);


             Console.WriteLine($"Total marks = {total}");
             Console.WriteLine($"Average Marks = {average}");
             Console.WriteLine($"Percentage = {percentage}");*/



            //11- Write a program to input the month number and print the number of days in that month.

            /*    Console.Write("Enter the month number (1-12): ");
                int monthNumber;
                while (!int.TryParse(Console.ReadLine(), out monthNumber) || monthNumber < 1 || monthNumber > 12)
                    Console.Write("Invalid input. Please enter a valid month number (1-12): ");


                switch (monthNumber)
                {
                    case 2: 
                        Console.WriteLine($"Days in Month: 28");
                        break;

                    case 4:
                    case 6: 
                    case 9:
                    case 11: 
                        Console.WriteLine($"Days in Month: 30");
                        break;

                    default: 
                        Console.WriteLine($"Days in Month: 31");
                        break; 
                }
            */


            //12- Write a program to create a Simple Calculator.
            /*    Console.Write("Enter the first number: ");
                double num1;
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                Console.Write("Enter the operator (+, -, *, /): ");
                char op;
                while (!char.TryParse(Console.ReadLine(), out op) || (op != '+' && op != '-' && op != '*' && op != '/'))
                {
                    Console.Write("Invalid input. Please enter a valid operator (+, -, *, /): ");
                }

                Console.Write("Enter the second number: ");
                double num2;
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                double result = 0;
                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                            return;
                        }
                        break;
                }

                Console.WriteLine($"Result: {result}");
            */


            //13- Write a program to allow the user to enter a string and print the REVERSE of it.
            /* Console.Write("Enter a string: ");
             string input = Console.ReadLine();

             StringBuilder reversed = new StringBuilder();

             for (int i = input.Length - 1; i >= 0; i--)
                 reversed.Append(input[i]);


             Console.WriteLine($"Reversed string: {reversed}");
            */


            //14- Write a program to allow the user to enter int and print the REVERSED of it.
            /*
                        int num = int.Parse(Console.ReadLine());

                        int reversed = 0;
                        while (num != 0)
                        {
                            int digit = num % 10;
                            reversed = reversed * 10 + digit;
                            num /= 10;
                        }
                        Console.WriteLine(reversed); */




            //15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            /*
                        Console.Write("Input starting number of range: ");
                        int startNumber = int.Parse(Console.ReadLine());

                        Console.Write("Input ending number of range: ");
                        int endNumber = int.Parse(Console.ReadLine());

                       
                        Console.Write("The prime numbers between {0} and {1} are: ", startNumber, endNumber);
                        for (int num = startNumber; num <= endNumber; num++)
                        {
                            if (IsPrime(num))
                            {
                                Console.Write(num + " ");
                            }
                        }*/


            //16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            /* Console.Write("Enter a decimal number: ");
             int decimalNumber = int.Parse(Console.ReadLine());


                 string binary = DecimalToBinary(decimalNumber);


                 Console.WriteLine($"Binary representation: {binary}");*/


            //17-
            /*
                        Console.WriteLine("Enter three points (x1, y1), (x2, y2), and (x3, y3):");

                        Console.Write("x1: ");
                        double x1 = double.Parse(Console.ReadLine());
                        Console.Write("y1: ");
                        double y1 = double.Parse(Console.ReadLine());

                        Console.Write("x2: ");
                        double x2 = double.Parse(Console.ReadLine());
                        Console.Write("y2: ");
                        double y2 = double.Parse(Console.ReadLine());

                        Console.Write("x3: ");
                        double x3 = double.Parse(Console.ReadLine());
                        Console.Write("y3: ");
                        double y3 = double.Parse(Console.ReadLine());

                        double slope1 = (y2 - y1) / (x2 - x1);
                        double slope2 = (y3 - y2) / (x3 - x2);

                        if (Math.Abs(slope1 - slope2) == 0.00001)
                        {
                            Console.WriteLine("The points lie on a single straight line.");
                        }
                        else
                        {
                            Console.WriteLine("The points do not lie on a single straight line.");
                        }*/


            //18-

            /*Console.Write("Enter the time taken for the task in hours: ");
            if (double.TryParse(Console.ReadLine(), out double timeTaken))
            {
                string efficiencyLevel = GetEfficiencyLevel(timeTaken);

                Console.WriteLine($"Efficiency Level: {efficiencyLevel}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid time in hours.");
            }*/


            //19
            /*
                        Console.Write("Enter the value of n for the identity matrix: ");
                        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                        {

                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (i == j)
                                    {
                                        Console.Write("1 ");
                                    }
                                    else
                                    {
                                        Console.Write("0 ");
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a positive integer for n.");
                        }*/


            //20

            /*   Console.Write("Enter the size of the array: ");

               int size=int.Parse(Console.ReadLine());

               int[] array = new int[size];

               for (int i = 0; i < size; i++)
               {
                   Console.Write($"Enter element {i + 1}: ");

                       array[i] = int.Parse(Console.ReadLine());

               }

               int sum = 0;
               for (int i = 0; i < size; i++)
               {
                   sum += array[i];
               }

               Console.WriteLine($"The sum of all elements of the array is: {sum}");


               */



            //21

            /*  Console.Write("Enter the size of the arrays: ");
              int size = int.Parse(Console.ReadLine());

              int[] array1 = new int[size];
              int[] array2 = new int[size];
              int[] mergedArray = new int[size * 2];

              Console.WriteLine("Enter elements for array1 (in ascending order):");
              for (int i = 0; i < size; i++)
              {
                  Console.Write($"Enter element {i + 1}: ");
                  array1[i] = int.Parse(Console.ReadLine());
              }

              Console.WriteLine("Enter elements for array2 (in ascending order):");
              for (int i = 0; i < size; i++)
              {
                  Console.Write($"Enter element {i + 1}: ");
                  array2[i] = int.Parse(Console.ReadLine());
              }

              int index1 = 0;
              int index2 = 0;
              for (int i = 0; i < size * 2; i++)
              {
                  if (index1 < size && (index2 >= size || array1[index1] <= array2[index2]))
                  {
                      mergedArray[i] = array1[index1];
                      index1++;
                  }
                  else
                  {
                      mergedArray[i] = array2[index2];
                      index2++;
                  }
              }

              Console.WriteLine("Merged array in ascending order:");
              for (int i = 0; i < size * 2; i++)
              {
                  Console.Write(mergedArray[i] + " ");
              }*/



            //22

            /*
                        Console.Write("Enter the size of the array: ");
                        int size = int.Parse(Console.ReadLine());

                        int[] array = new int[size];

                        Console.WriteLine("Enter elements for the array:");
                        for (int i = 0; i < size; i++)
                        {
                            Console.Write($"Enter element {i + 1}: ");
                            array[i] = int.Parse(Console.ReadLine());
                        }

                        int[] frequencyArray = new int[101]; // Assuming elements range from 0 to 100

                        foreach (int num in array)
                        {
                            frequencyArray[num]++;
                        }

                        Console.WriteLine("Frequency of each element in the array:");
                        for (int i = 0; i < 101; i++)
                        {
                            if (frequencyArray[i] > 0)
                            {
                                Console.WriteLine($"Element {i} occurs {frequencyArray[i]} times.");
                            }
                        }*/


            //23
            /*
                        Console.Write("Enter the size of the array: ");
                        int size = int.Parse(Console.ReadLine());

                        int[] array = new int[size];

                        for (int i = 0; i < size; i++)
                        {
                            Console.Write($"Enter element {i + 1}: ");
                            array[i] = int.Parse(Console.ReadLine());
                        }

                        int maxElement = array[0];
                        int minElement = array[0];

                        for (int i = 1; i < size; i++)
                        {
                            if (array[i] > maxElement)
                            {
                                maxElement = array[i];
                            }

                            if (array[i] < minElement)
                            {
                                minElement = array[i];
                            }
                        }

                        Console.WriteLine($"Maximum element: {maxElement}");
                        Console.WriteLine($"Minimum element: {minElement}");
            */



            //24

            /*  Console.Write("Enter the size of the array: ");
              int size = int.Parse(Console.ReadLine());

              int[] array = new int[size];

              for (int i = 0; i < size; i++)
              {
                  Console.Write($"Enter element {i + 1}: ");
                  array[i] = int.Parse(Console.ReadLine());
              }

              int largest = int.MinValue;
              int secondLargest = int.MinValue;

              for (int i = 0; i < size; i++)
              {
                  if (array[i] > largest)
                  {
                      secondLargest = largest;
                      largest = array[i];
                  }
                  else if (array[i] > secondLargest && array[i] < largest)
                  {
                      secondLargest = array[i];
                  }
              }

              if (secondLargest == int.MinValue)
              {
                  Console.WriteLine("There is no second largest element in the array.");
              }
              else
              {
                  Console.WriteLine($"The second largest element in the array is: {secondLargest}");
              }*/



            //25
            /* Console.Write("Enter the size of the array: ");
             int size = int.Parse(Console.ReadLine());

             int[] array = new int[size];

             for (int i = 0; i < size; i++)
             {
                 Console.Write($"Enter element {i + 1}: ");
                 array[i] = int.Parse(Console.ReadLine());
             }

             int longestDistance = 0;

             for (int i = 0; i < size; i++)
             {
                 for (int j = i + 1; j < size; j++)
                 {
                     if (array[i] == array[j])
                     {
                         int distance = j - i - 1;
                         longestDistance = Math.Max(longestDistance, distance);
                     }
                 }
             }

             Console.WriteLine($"The longest distance between two equal cells is: {longestDistance}");


             */


            //26

          /*  Console.Write("Enter a list of space-separated words: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

          
           Array.Reverse(words);

            string reversedInput = string.Join(" ", words);

            Console.WriteLine(reversedInput);
          */










        }


    }

}