using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp2.Book
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            if (B == null)
            {
                throw new ArgumentNullException(nameof(B), "Book cannot be null.");
            }

            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            if (B == null)
            {
                throw new ArgumentNullException(nameof(B), "Book cannot be null.");
            }

            return string.Join(", ", B.Authors);
        }

        public static decimal GetPrice(Book B)
        {
            if (B == null)
            {
                throw new ArgumentNullException(nameof(B), "Book cannot be null.");
            }

            return B.Price;
        }
    }
}
