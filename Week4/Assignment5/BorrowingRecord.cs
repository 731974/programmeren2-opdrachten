using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public class BorrowingRecord
    {

        public Person Borrower { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime DueDate { get; set;}

        public BorrowingRecord(Person borrower, DateTime borrowedDate, DateTime dueDate)
        {
            Borrower = borrower;
            BorrowDate = borrowedDate;
            DueDate = dueDate;
        }
    }
}
