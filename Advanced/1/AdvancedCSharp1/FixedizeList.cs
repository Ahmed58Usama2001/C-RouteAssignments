using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp1
{
    class FixedSizeList<T>
    {
        private T[] array;
        private int capacity;
        private int count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be a positive value.");
            }

            this.capacity = capacity;
            array = new T[capacity];
            count = 0;
        }

        public int Count => count;

        public void Add(T item)
        {
            if (count >= capacity)
            {
                throw new InvalidOperationException("Cannot add more elements. The list has reached its capacity.");
            }

            array[count] = item;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index is out of valid range.");
                }

                return array[index];
            }
        }
    }

}
