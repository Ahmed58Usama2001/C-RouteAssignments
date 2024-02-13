using DEMO.Static;

namespace DEMO
{
    public class program
    {
        static void Main()
        {
            #region Operator overloading

            Complex c1 = new Complex() { Real = 1, Img = 5 };
            Complex c2=new Complex() { Real = 4, Img = 7 };


            //Complex c3 = default; //null

            //c3=c1+ c2;
            //Console.WriteLine(c3);


            //c3 = c1 + 5;
            //Console.WriteLine(c3);

            //c2 += c1;
            //Console.WriteLine(c2);

            //c3++;
            //Console.WriteLine(c3);

            //c1 = c2;

            //if(c1==c2)
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");

            int X = c1;
            Console.WriteLine(X);

            string Y = (string)c2;

            #endregion


            #region MyRegion

            //Employee employee = new Employee()
            //{
            //    ID = 1,
            //    FullName = "Ahmed Usama Saad",
            //    Salary = 3000
            //};

            //Person person = employee;
            //Console.WriteLine(person);




            #endregion


            #region Static

         //   Utility utility = new Utility(10, 20);

            //Console.WriteLine(Utility.ConvertFromCmToInches(100)); //static method

            //Console.WriteLine(Utility.CalculateCircleArea(50));

            #endregion







        }
    }
}
