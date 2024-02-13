using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.SortingAlgorithms
{
    public delegate bool CompareDelegate(int left, int right);
    public class SortingAlgorithm
    {
        public static void BubbleSort(int[] arr, CompareDelegate compare )
        {
            for (int i = 0; i < arr?.Length; i++)
            {for (int j = 0; j < arr?.Length-i-1; j++)
                {
                    if (compare.Invoke(arr[j], arr[j+1]))
                        Swap(ref arr[j], ref arr[j + 1]);
                }
                
            }
        }

        //public static void BubbleSortDescinding(int[] arr)
        //{
        //    for (int i = 0; i < arr?.Length; i++)
        //    {
        //        for (int j = 0; j < arr?.Length - i - 1; j++)
        //        {
        //            if (arr[j] < arr[j + 1])
        //                Swap(ref arr[j], ref arr[j + 1]);
        //        }

        //    }
        //}

        public static void Swap(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }

    }

    public class CompareMethods
    {
        public static bool CompareGreaterThan(int Left,int Right)
        {
            return Left > Right;
        }

        public static bool CompareLessThan(int Left, int Right)
        {
            return Left < Right;
        }

    }

}
