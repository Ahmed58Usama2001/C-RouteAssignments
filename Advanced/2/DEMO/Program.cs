using DEMO.SortingAlgorithms;
using DEMO.GenericSortingAlgorithms;

namespace DEMO
{
    //Delegate is a CSharp feature has 2 uses:
    //Pointer to method or More
    //Event driven programming

    //Step 0: Delegate declaration
    public delegate int StringMethodDelegate(string word);
    public delegate bool ConditionDelegate(int X);

    //Delegate ==> Class, any reference from this delegate can refere to one method or more
    //Pointer or method (static method or object method)
    //these methods must be with the same signature
    //regardless method name or access modifier 

    //Generic delegates
    //Predicate==> refer to a method that returns a bool and has one parameter whatever its datatype 
    //Func==> refers to a method that returns a value and has from 0 to 16 parameters with whatever datatype
    //Action==>refers to a method that returns nothing and has from 0 to 16 parameters with whatever datatype



    internal class program
    {
        public static List<int> GetOddNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if(number%2!=0)
                {
                    result.Add(number);
                }
            }
            return result;
        }

        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2== 0)
                {
                    result.Add(number);
                }
            }
            return result;
        }

        public static List<int> GetFilteredNumbers(List<int> numbers,ConditionDelegate condition)
        {
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (condition.Invoke(number))
                {
                    result.Add(number);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            #region delegate EX1

            //step 1: Create reference from delegate
            StringMethodDelegate stringMethodDelegate;

            //step 2: initialize reference: Point to method
            stringMethodDelegate = new StringMethodDelegate(StringMethods.CountUpperCaseChars);
            stringMethodDelegate += StringMethods.CountLowerCaseChars;

            //step 3: use delegate reference (Call Method)
          //  int result = stringMethodDelegate.Invoke("Ahmed");
            int result = stringMethodDelegate("Ahmed");

            Console.WriteLine(result);


            #endregion

            #region Example 2

            //int[] arr1 = { 5, 1, 7, 32, 64, 12, 314, 63 };

            //CompareDelegate compare = new(CompareMethods.CompareGreaterThan);

            //SortingAlgorithm.BubbleSort(arr1,compare);

            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            // compare = new(CompareMethods.CompareLessThan);

            //SortingAlgorithm.BubbleSort(arr1, compare);

            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Example 2 Generic Version

            //int[] arr1 = { 5, 1, 7, 32, 64, 12, 314, 63 };

            //CompareGenericDelegate<int,int,bool> compare = new(CompareGenericMethods.CompareGreaterThan);

            //GenericSortingAlgorithm<int>.BubbleSort(arr1, compare);

            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //compare = new(CompareGenericMethods.CompareLessThan);

            //GenericSortingAlgorithm<int>.BubbleSort(arr1, compare);

            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Example 3

            //List<int> numbers = Enumerable.Range(0,100).ToList();

            //List<int>Result=GetFilteredNumbers(numbers,ConditionsMethod.CheckEven);

            //foreach (var item in Result)
            //{
            //    Console.Write(item);
            //}

            //List<int> Result = GetFilteredNumbers(numbers, ConditionsMethod.CheckOdd);

            //foreach (var item in Result)
            //{
            //    Console.Write(item);
            //}

            #endregion

        }
    }

    public class  StringMethods
    {
        public static int CountUpperCaseChars(string word)
        { int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                    count++;
            }
            return count;
        }

        public static int CountLowerCaseChars(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLower(word[i]))
                    count++;
            }
            return count;
        }


    }

    public class ConditionsMethod
    {
        public static bool CheckOdd(int X)
        {
            return X % 2 != 0;
        }

        public static bool CheckEven(int X)
        {
            return X % 2 == 0;
        }

    }

}
