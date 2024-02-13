using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp2.Book
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            if (string.IsNullOrWhiteSpace(_ISBN) || string.IsNullOrWhiteSpace(_Title) || _Authors == null || _Authors.Length == 0 || _Price <= 0)
            {
                throw new ArgumentException("Invalid book parameters.");
            }

            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
        {
            return $"Title: {Title}, ISBN: {ISBN}, Authors: {string.Join(", ", Authors)}, Publication Date: {PublicationDate}, Price: {Price:C}";
        }
    }
}
