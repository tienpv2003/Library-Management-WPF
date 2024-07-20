using LibaryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagement.IRepository
{
    public interface IBorrowBookRepository
    {
        public IEnumerable<BorrowBook> GetBorrowList();
        public BorrowBook GetBorrowBook(string bookId, string studentId);
        public void InsertBorrowBook(BorrowBook borrow);
        public void DeleteBorrowBook(BorrowBook borrow);
        public void UpdateBorrowBook(BorrowBook borrow);
    }
}
