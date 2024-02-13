
namespace Demo;

internal class Program
{

    public static void Print()
    {
        Console.WriteLine("Test");
    }

    public static void Print(string message)
    {
        Console.WriteLine(message);
    }

    public static void Print(int number,string pattern="@") //optional parameters has to be at the end of parameters list
    {
        for (int i = 0; i < number; i++)
            Console.WriteLine(pattern);
    }


    public static void Swap(int x,int y)
    {
        Console.WriteLine($"num 1 = {x} , num2= {y}");
        int temp=x;
        x=y; y=temp;
        Console.WriteLine("After inside swap");
        Console.WriteLine($"num 1 = {x} , num2= {y}");
    }

    public static void Swap( ref int x,ref int y)
    {
        Console.WriteLine($"num 1 = {x} , num2= {y}");
        int temp = x;
        x = y; y = temp;
        Console.WriteLine("After inside swap");
        Console.WriteLine($"num 1 = {x} , num2= {y}");
    }

    public static int SumArray(int[] arr)
    {
        int sum = 0;
        arr[0] = 100;
        arr = new int[] { 4, 5, 6 };
        for (int i = 0; i < arr.Length; i++)
            sum+=arr[i];

        return sum;
    }

    public static int SumArray(ref int[] arr)
    {
        int sum = 0;
        arr[0] = 100;
        arr = new int[] { 4, 5, 6 };
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];

        return sum;
    }


    public static void SumMul(int num1,int num2,out int sum,out int mul)
    {
        sum=num1 + num2;
        mul=num1 * num2;    
    }

    public static int SumArray(int sum=0,params int[] arr) //params must be the last parameter
    {
       
        
       
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];

        return sum;
    }

    static void Main(string [] args)

    {
        #region boxing and unboxing

        object obj = new object();

        obj = 5;
        obj = false;
        obj = "Ahmed";
        obj = 'a';

        int x = 5;

        obj = x;
        //boxing==>casting between object (reference type) and any value type  implicitly  safe casting  parent=child



        int y = (int)obj;
        //explicitly  child=parent   unsafe casting  unboxing


        #endregion



        #region Null types

        //Nullable types==>value types that allow null
        //assign null to value type variable

        int? a = null;
        int b = 0;
        //default value now is null it also accepts nulls

     

        a = b; //safe casting implicit casting
        b = (int)a; //unsafe casting explicit casting



        /*   if (a.HasValue)
               b = a.Value;
           else
               b = 0;
        */

        //b=a.HasValue? a.Value : 0;


        //Null coalescing operator
        b = a ?? 0; //check if a is null


        #endregion


        #region Null propagation operator

        double d = default; //0

        int []? arr=default; //null. The ? is useless because reference type acceps nulls

        for(int i=0; i<arr?.Length; i++)  //the ? makes code more safe not to throw an exception. It doesn't mean nullable. it's for checking
            Console.WriteLine(arr[i]);

      //  int? length = arr.Length;
        int length= arr?.Length ?? 0;  //had to use ? because we can't use ?? with int type so we have to make it nullable

        #endregion


        #region methods

        Print(10, "#");

        Print(pattern: "%", number: 20);

        #endregion


        #region value type==>passing parameters by value

    /*    int num1 = 10,num2 = 20;

        Console.WriteLine($"num 1 = {num1} , num2= {num2}");
        Swap(num1, num2);
        Console.WriteLine("After swap:");
        Console.WriteLine($"num 1 = {num1} , num2= {num2}");
    */
        #endregion


        #region value type==>passing parameters by reference

        int num1 = 10, num2 = 20;

        Console.WriteLine($"num 1 = {num1} , num2= {num2}");
        Swap(ref num1,ref num2);
        Console.WriteLine("After swap:");
        Console.WriteLine($"num 1 = {num1} , num2= {num2}");

        #endregion


        #region reference type==>passing parameters by value

        int[] Arr1 =  { 1, 2, 3 };
        Console.WriteLine(SumArray(Arr1));
        Console.WriteLine(Arr1[0]); //100

        #endregion

        #region reference type==>passing parameters by reference

        int[] Arr2 = { 1, 2, 3 };
        Console.WriteLine(SumArray(ref Arr2));
        Console.WriteLine(Arr2[0]); //4

        #endregion


        #region passing by out

        int number1=5,number2=10,SumResult,MulResult; //we can't use reference unless we initialize the variables, but in case of using out we can neglect initializing them

        SumMul(number1, number2, out SumResult, out MulResult);  

        Console.WriteLine(SumResult+ ' '+ MulResult); //15 50


        //Passing by value==>ReadOnly
        //By reference==>Read first then write (must be initialized before being passed)
        //By Out==> write at first then read (must be initialized inside the method)


        #endregion

        #region Params

        int result=SumArray(10,1,1,1,1); //the 10 is assigned to the first parameter called sum
        Console.WriteLine(result);

        #endregion

    }
}
