﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Book
    {

        public string Title, Author, ISBN;

        public Book(string title, string author, string isbn)
        {

            Title = title;
            Author = author;
            ISBN = isbn;

        }

        public override string ToString()
        {
            return $"Book Title: {Title}, Author: {Author}, ISBN: {ISBN}";
        }

    }
}
