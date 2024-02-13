using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Static
{
    //Static class is a container for static members ==>Attribute, Property, constructor, method + constant
    //You can not create an object from static class
    //No inheritance from static class
    public static class Utility
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        //public Utility(int _X,int _y)
        //{
        //    X = _X;
        //    Y = _y;
        //    //PI = 3.14;
        //    //Object constructor is not the right place to initialize a static attribute
        //}

        //Static Constructor [only one static constructor in the class]
        //Doesn't have access modifiers or parameters
        //will be excuted only once per class lifetime before the first usage of the class
        //1. call static method or static property
        //2.Create object from the class
        //3. Create object from another class that inherit from this class

        static Utility()
        {
            PI = 3.14;
        }

        public static double ConvertFromCmToInches(double Cm)  //self contained rely on parameters passed from outside the class so will make it static
        {
            return Cm / 2.54;
        }

        static double PI;
        public static double CalculateCircleArea(double radius)
        {
            return PI * radius * radius;
        }

    }
}
