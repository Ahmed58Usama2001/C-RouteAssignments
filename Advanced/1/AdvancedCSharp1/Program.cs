
using System.Collections;

namespace AdvancedCSharp1;
public class program
{
    static void OptimizedBubbleSort<T>(T[] arr) where T : IComparable<T>
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j].CompareTo(arr[j + 1]) > 0)
                {
                    // Swap arr[j] and arr[j+1]
                    T temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were swapped in the inner loop, the array is already sorted
            if (!swapped)
                break;
        }
    }

    static void ReverseArrayList(ArrayList list)
    {
        int left = 0;
        int right = list.Count - 1;

        while (left < right)
        {
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;

            left++;
            right--;
        }
    }

    static List<int> GetEvenNumbers(List<int> inputList)
    {
        List<int> evenNumbers = new List<int>();

        foreach (int number in inputList)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        return evenNumbers;
    }

    static int FindFirstNonRepeatedCharacterIndex(string input)
    {
        Dictionary<char, int> charFrequency = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charFrequency.ContainsKey(c))
                charFrequency[c]++;
            else
                charFrequency[c] = 1;
        }

        for (int i = 0; i < input.Length; i++)
        {
            if (charFrequency[input[i]] == 1)
                return i;
        }

        return -1;
    }

    static void Main(string[] args)
    {
        #region question 1
        //int[] intArr = { 64, 34, 25, 12, 22, 11, 90 };
        //string[] strArr = { "apple", "banana", "orange", "grape", "pear" };

        //Console.WriteLine("Original integer array:");
        //foreach (int num in intArr)
        //{
        //    Console.Write(num + " ");
        //}

        //OptimizedBubbleSort(intArr);

        //Console.WriteLine("\nSorted integer array:");
        //foreach (int num in intArr)
        //{
        //    Console.Write(num + " ");
        //}

        //Console.WriteLine("\nOriginal string array:");
        //foreach (string str in strArr)
        //{
        //    Console.Write(str + " ");
        //}

        //OptimizedBubbleSort(strArr);

        //Console.WriteLine("\nSorted string array:");
        //foreach (string str in strArr)
        //{
        //    Console.Write(str + " ");
        //}


        #endregion


        #region question 2

        //Range<int> intRange = new Range<int>(10, 20);
        //Console.WriteLine($"Is 15 in the range? {intRange.IsInRange(15)}"); // Should print: True
        //Console.WriteLine($"Is 5 in the range? {intRange.IsInRange(5)}");   // Should print: False
        //Console.WriteLine($"Range length: {intRange.Length()}");            // Should print: 10

        //Range<double> doubleRange = new Range<double>(5.0, 7.5);
        //Console.WriteLine($"Is 6.2 in the range? {doubleRange.IsInRange(6.2)}");   // Should print: True
        //Console.WriteLine($"Is 8.0 in the range? {doubleRange.IsInRange(8.0)}");   // Should print: False
        //Console.WriteLine($"Range length: {doubleRange.Length()}");               // Should print: 2.5

        //Range<string> stringRange = new Range<string>("apple", "banana");
        //Console.WriteLine($"Is 'cherry' in the range? {stringRange.IsInRange("cherry")}"); // Should print: True
        //Console.WriteLine($"Is 'pear' in the range? {stringRange.IsInRange("pear")}");     // Should print: False


        #endregion


        #region question 3

        //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
        //Console.WriteLine("Original ArrayList: " + string.Join(", ", arrayList));

        //ReverseArrayList(arrayList);
        //Console.WriteLine("Reversed ArrayList: " + string.Join(", ", arrayList));

        #endregion

        #region question 4
        //List<int> inputList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //List<int> evenNumbers = GetEvenNumbers(inputList);

        //Console.WriteLine("Original List: " + string.Join(", ", inputList));
        #endregion


        #region question 5

        //FixedSizeList<int> fixedList = new FixedSizeList<int>(5);

        //try
        //{
        //    fixedList.Add(1);
        //    fixedList.Add(2);
        //    fixedList.Add(3);
        //    fixedList.Add(4);
        //    fixedList.Add(5);

        //    // Uncommenting the next line will result in an InvalidOperationException
        //    // fixedList.Add(6);

        //    Console.WriteLine("Elements in the FixedSizeList:");
        //    for (int i = 0; i < fixedList.Count; i++)
        //    {
        //        Console.WriteLine(fixedList[i]);
        //    }

        //    // Uncommenting the next line will result in an IndexOutOfRangeException
        //    // Console.WriteLine(fixedList[5]);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Error: " + ex.Message);
        //}

        #endregion

        #region question 6
        string input = "abacdbef";
        int index = FindFirstNonRepeatedCharacterIndex(input);

        if (index != -1)
            Console.WriteLine($"The first non-repeated character is '{input[index]}' at index {index}.");
        else
            Console.WriteLine("No non-repeated character found in the string.");
        #endregion

    }


}


