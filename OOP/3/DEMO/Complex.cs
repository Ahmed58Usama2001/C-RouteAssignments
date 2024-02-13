using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    public class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Img}i:";
        }

        public static Complex operator +(Complex left, Complex Right)
        {
            return new Complex()
            {
                Real = (left?.Real??0) + (Right?.Real??0),
                Img = (left?.Img??0) + (Right?.Img??0)
            };
        }

        public static Complex operator +(Complex left, int Right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) + (Right),
                Img = (left?.Img ?? 0) 
            };
        }

        public static Complex operator ++(Complex left)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) +1,
                Img = (left?.Img ?? 0)
            };
        }

        public static bool operator ==(Complex left, Complex Right)
        {
            if (left?.Real == Right?.Real&&left?.Img==Right?.Img)
                return true;
            else
                return false;
        }

        public static bool operator !=(Complex left, Complex Right)
        {
            if (left.Real != Right.Real)
                return true;
            else
                return false;
        }

        public static implicit operator int(Complex complex)
        {
            return complex?.Real??0;
        }

        public static explicit operator string(Complex complex)
        {
            return complex?.ToString() ?? "Not available";
        }


    }
}
