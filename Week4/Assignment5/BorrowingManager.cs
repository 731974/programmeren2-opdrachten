using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public class BorrowingManager
    {
        public void BorrowItem(LibraryItem item, Person person, DateTime dueDate)
        {
            DateTime today = DateTime.Now;
            BorrowingRecord record = new BorrowingRecord(person, today, dueDate);
            item.BorrowingHistory.Add(record);
            item.Borrow();
        }

        public void ReturnItem(LibraryItem item)
        {
            item.IsBorrowed = false;
        }
    }
}