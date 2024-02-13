using _Demo.Interface;

namespace Test
{
    internal class Program
    {

       static void Main()
        {

        }

    }

    public interface IDemo
    {
        public void PrintFromInterface();
    }

    public class myclass: IMyType,IDemo
    {
        public decimal Salary { get; set; }

         void IMyType.PrintFromInterface() //has to be private. It can't be inherited
        {
            Console.WriteLine("hi");
        }

         void IDemo.PrintFromInterface() //has to be private. It can't be inherited
        {
            Console.WriteLine("hi");
        }

    }

}