using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    public class Helper <T>where T : IComparable
    {//constraints

      //1 Primary Constraint=?[0:1]

        //1.1 General Primary constraint
        //T must be a Class
        //T must be a struct
        //T must be an Enum

        //1.2 Special Primary Constraint
        //Point==>specific class==>T must be point or a class inheriting from Point

      //2 Secondary constraint (interface constraint)
        //classes and structs that implements the interface

      //3 Constructor constraint==>[0:1]
        //T must be a dataType that have an accessable parameterless constructor


        #region Non Generic swap

        
        //public static void Swap( ref int x,ref int y)
        //{
        //    int temp = x;
        //    x=y;
        //    y=temp;
        //}

        //public static void Swap(ref double x, ref double y)
        //{
        //    double temp = x;
        //    x = y; y = temp;
        //}

        //public static void Swap(ref string x, ref string y)
        //{
        //    string temp = x;
        //    x = y; y = temp;
        //}

        //public static void Swap(ref Point x, ref Point y)
        //{
        //    Point temp = x;
        //    x = y; y = temp;
        //}
        #endregion

        public static int SearchArray(T[] arr, T value)
        {
            for(int i = 0; i<arr?.Length;i++)
                if (arr[i].Equals(value))return i;

            return -1;
        }

public static void  Swap(ref T x, ref T y)
        {
            T temp = x; x=y; y=temp;
        }

        public static void BubbleSort(T[] arr)
        {
            for (int i = 0; i < arr?.Length; i++)
                for (int j = 0; j < arr.Length - i - 1; i++)
                    if (arr[j].CompareTo(arr[j + 1])==1)  //must be used from interface Icomparable
                        Swap(ref arr[j] , ref arr[j + 1]);
        }

    }
}
