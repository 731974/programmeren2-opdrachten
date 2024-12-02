using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public abstract class LibraryItem : IBorrowable
    {

        public string Title { get; set; }
        public string Author { get; set; }

        public string ISBN { get; set; }

       public bool IsBorrowed { get; set; }

        public List<BorrowingRecord> BorrowingHistory { get; set; }



        public LibraryItem(string title, string author, string isbn) 
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = false;
            BorrowingHistory = new List<BorrowingRecord>();
        }

        public Person GetCurrentBorrower()
        {

            if (BorrowingHistory.Count == 0)
                throw new InvalidOperationException();

            return BorrowingHistory[BorrowingHistory.Count - 1].Borrower;
        }

        public void Borrow()
        {
            IsBorrowed = true;
        }


        public void Return()
        {
            IsBorrowed = false;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Borrowed: {IsBorrowed}";

        }



    }
}
