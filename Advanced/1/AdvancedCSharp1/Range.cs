using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp1
{
    public class Range<T> where T : IComparable<T>
    {
        private T minimum;
        private T maximum;

        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException("Minimum value must be less than or equal to the maximum value.");
            }

            this.minimum = minimum;
            this.maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(minimum) >= 0 && value.CompareTo(maximum) <= 0;
        }

        public T Length()
        {
            dynamic min = minimum;
            dynamic max = maximum;
            return max - min;
        }
    }

}
