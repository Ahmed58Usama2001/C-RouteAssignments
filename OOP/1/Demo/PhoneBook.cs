using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public struct PhoneBook
    {
        string[]? names;

        long[]? numbers;
     
        private int size;

        public int Size
        {
            get { return size; }
            
        }


        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }

        #region getter and setter

        public long GetNumber(string name)
        {
            for(int i = 0; i < names.Length; i++)
                if(names[i] == name)
                    return numbers[i];

            return -1;

        }
        public void UpdateNumber(string name,long number)
        {
            for(int i = 0; i < names?.Length; i++)
                if(name== names[i]) 
                numbers[i] = number;
        }

        public AddNewNumber(string name,long number,int position)
        {
            if(position>=0 && position<size)
            {
                names[position] = name;
                numbers[position] = number;
            }
        }

        public int GetSize()
        {
            return size;
        }

        #endregion


        #region Indexer=> Special property

        public long this[string name]
        {
            get
            {

                for (int i = 0; i < names.Length; i++)
                    if (names[i] == name)
                        return numbers[i];

                return -1;
            }

            set
            {

                for (int i = 0; i < names?.Length; i++)
                    if (name == names[i])
                        numbers[i] = value;
            }

        }


        public string this[int index]
        {
            get
            {
                return $"index= {index} :: name= {names[index]} :: number= {numbers[index]}"
            }
        }

        #endregion

    }
}
