using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Demo.Polymorphism__Override_
{
    public  class TypeA
    {
        public int A { get; set; }

        public TypeA(int _A)
        {
            A = _A;
        }


        public void StaticPrint()
        {
            Console.WriteLine(" I am Base (Parent)");
        }

        //must be non private and virtual method
        public virtual void DynamicPrint()
        {

            Console.WriteLine("Print A="+ A);
        }

    }

    public class TypeB:TypeA
    {
        public int B { get; set; }

        public TypeB(int _A,int _B):base(_A)
            {
            B= _B;  
             }


        public new void StaticPrint()
        {
            Console.WriteLine(" I am derived (child)");
        }


        public override void DynamicPrint()
        {
            Console.WriteLine("Print A=" + A + "Print B="+B);
        }

    }

    public class TypeC : TypeB
    {

        public int C { get; set; }

        public TypeC(int _A,int _B,int _C):base(_A,_B)
        {
            C= _C;
        }

        public override void DynamicPrint()
        {
            Console.WriteLine("Print A=" + A + "Print B=" + B + "Print C="+C);
        }

    }

    public class TypeD : TypeC
    {

        public int D { get; set; }

        public TypeD(int _A, int _B, int _C,int _D) : base(_A, _B,_C)
        {
            C = _C;
        }

        public new void DynamicPrint() //static binding because of new keyword
        {
            Console.WriteLine("Print A=" + A + "Print B=" + B + "Print C=" + C+" D="+D);
        }

    }

}
