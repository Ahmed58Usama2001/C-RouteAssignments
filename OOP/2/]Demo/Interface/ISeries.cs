using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Demo.Interface
{
    public interface ISeries
    {
        public int Current { get; set; }

        public void GetNext();

        void Reset()
        {
            Current = 0;
        }

    }


    public class SeriesByTwo : ISeries
    {
        public int  Current { get; set; }

        public void GetNext()
        {
            Current += 2;
        }
    }

    public class SeriesByThree : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 3;
        }
    }

}
