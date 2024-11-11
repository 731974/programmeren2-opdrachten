using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Book
    {
        private string title;
        private string author;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
      
        public override string ToString()
        {
            return $"Title: {title} \nAuthor: {author}";
        }
    }
}
