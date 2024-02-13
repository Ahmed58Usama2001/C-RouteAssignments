using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp2.Book
{
    public class LibraryEngine
    {
        // a) User-Defined Delegate
        public delegate string BookProcessingDelegate(Book book);

        public static void ProcessBooksByDelegate(List<Book> blist, BookProcessingDelegate fPtr)
        {
            Console.WriteLine("Processing books using User-Defined Delegate:");
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        // b) Proper Built-in Delegate (Func delegate)
        public static void ProcessBooksByFunc<T>(List<T> blist, Func<T, string> fPtr)
        {
            Console.WriteLine("Processing books using Proper Built-in Delegate (Func delegate):");
            foreach (T B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        // c) Anonymous Method (GetISBN)
        public static void ProcessBooksByAnonymous(List<Book> blist, BookProcessingDelegate fPtr)
        {
            Console.WriteLine("Processing books using Anonymous Method (GetISBN):");
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        // d) Lambda Expression (GetPublicationDate)
        public static void ProcessBooksByLambda(List<Book> blist, BookProcessingDelegate fPtr)
        {
            Console.WriteLine("Processing books using Lambda Expression (GetPublicationDate):");
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }





}
