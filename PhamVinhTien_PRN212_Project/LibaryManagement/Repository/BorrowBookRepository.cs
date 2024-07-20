using LibaryManagement.BusinessObject;
using LibaryManagement.Models;
using LibaryManagement.IRepository;
using System.Collections.Generic;

namespace LibaryManagement.Repository
{
    public class BorrowBookRepository : IBorrowBookRepository
    {
        public void DeleteBorrowBook(BorrowBook borrow) => BorrowBookObject.Instance.Remove(borrow);

        public BorrowBook GetBorrowBook(string bookId, string studentId) => BorrowBookObject.Instance.GetBorrowBook(bookId, studentId);

        public IEnumerable<BorrowBook> GetBorrowList() => BorrowBookObject.Instance.GetBorrowBookList();

        public void InsertBorrowBook(BorrowBook borrow) => BorrowBookObject.Instance.AddNew(borrow);

        public void UpdateBorrowBook(BorrowBook borrow) => BorrowBookObject.Instance.Update(borrow);
    }
}
