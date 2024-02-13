using DEMO.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.GenericSortingAlgorithms
{
    public delegate TResult CompareGenericDelegate<in T1,in T2,out TResult>(T1 left, T2 right);

    public class GenericSortingAlgorithm<T>
    {
        public static void BubbleSort(T[] arr, CompareGenericDelegate<T,T,bool> compare)
        {
            for (int i = 0; i < arr?.Length; i++)
            {
                for (int j = 0; j < arr?.Length - i - 1; j++)
                {
                    if (compare.Invoke(arr[j], arr[j + 1]))
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

        public static void Swap(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

    }

    public class CompareGenericMethods
    {
        public static bool CompareGreaterThan(int Left, int Right)
        {
            return Left > Right;
        }

        public static bool CompareLessThan(int Left, int Right)
        {
            return Left < Right;
        }

    }


}
