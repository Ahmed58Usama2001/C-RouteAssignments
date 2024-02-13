using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Demo.Interface
{//Default access modifier is public 
 //U can not private access modifier inside interface
    public interface IMyType
    {//what can you write inside interface?
        //1. Signature for property

        decimal Salary { get; set; }


        //2. Signature for method
        void PrintFromInterface();

        //3. Default implemented method==>CSharp 8
        void Print()
        {
            Console.WriteLine("Hello Interface");
        }


    }
}
