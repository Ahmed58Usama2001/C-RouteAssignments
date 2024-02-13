using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    public struct Point
    {
        //Attributes
       public int x, y;

        //Compilers will always generate parameterless constructor
        //public Point()
      //  {
     // x=y=0;
       // }
       //To initialize all the attributes with default values based on their datatype
       //You cannot create user defined parameterless constructor inside struct (Except for cSharp10 or greater)


        //when you create it, You must initialize all attributes


        //public Point(int _x,int _y)
        //{
        //     x= _x;
        //    y= _y; 
        //}

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(int z)
        {
            x = y = z;
        }

        public override string ToString()
        {
            return $"X= {x} - Y= {y}";
        }


    }
}
