using _Demo.Polymorphism__Override_;
using _Demo.Interface;

namespace Demo
{
    internal class program
    {
        #region Polymorphism==>method overloading

        public static int Sum(int x,int y)
            { return x + y; }

        public static int Sum(int x, int y,int z)
        { return x + y+z; }

        public static double Sum(double x, double y,double z)
        { return x + y+z; }

        #endregion

        #region interface example

        public static void ProcessSeries(ISeries series)
        {
            for(int i = 0; i < 20; i++)
            {
                Console.Write(series.Current+ ", ");
                series.GetNext();
            }
        }

        #endregion

        static void Main()
        {
            // Console.WriteLine(Sum(1,2));


            #region Polymorphism==>Overriding

            //TypeA typeA = new TypeA(10);

            //typeA.Print();

            //TypeB typeB = new TypeB(10, 20);

            //typeB.Print();  

            //TypeA typeA = new TypeB(10, 20);  //static binding - Early binding ==>method calls in compilation time based on reference type (Parent) not the object type (Child)

            //typeA.A = 10;
            //typeA.StaticPrint(); //Can see the parent methods and props only


            //TypeB typeB = new TypeB(10, 20);
            //typeB.DynamicPrint();


            //TypeA typeA = new TypeB(10, 20); //Dynamic binding - Late binding
            ////compiler bind method call based on Object type (Child) not the reference type (Parent) at runtime

            //typeA.DynamicPrint();

            //  TypeA type = new TypeC(10, 20, 30);
            //type.DynamicPrint();
            //

            // TypeA type = new TypeD(10, 20, 30, 40);
            // type.DynamicPrint(); //will run the last override in the hirarchy

            #endregion


            #region interface example 2
            //ISeries series2 = new SeriesByTwo();

            // ProcessSeries(series2);

            // ISeries series3 = new SeriesByThree();

            // ProcessSeries(series3);
            #endregion

            #region interface example 3
            //Employee employee1 = new Employee(1,"Ahmed",5000,"Tanta");

            //Employee employee2 = new Employee(2, "Ali", 2000, "Tanta");

            //employee1 = employee2; //Shallow copy

            //Console.WriteLine(employee1.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());

            ////  employee1 = new Employee(employee2); //Deep Copy using copy constructor

            //employee1 = (Employee)employee2.Clone();

            //Console.WriteLine(employee1.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());

            Employee[] employees = new Employee[]
          {new Employee(1,"Ahmed",3000,"Tanta"),
            new Employee(2, "Ali", 4000, "Tanta"),
            new Employee(3, "Omar", 1000, "Tanta"),
            new Employee(4, "Usama", 2000, "Tanta")
      };

            Array.Sort(employees);

            foreach (Employee employee in employees)
                Console.WriteLine(employee);


            #endregion





        }
    }



}