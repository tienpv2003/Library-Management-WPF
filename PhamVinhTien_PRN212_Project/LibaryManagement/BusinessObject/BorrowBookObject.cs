using LibaryManagement.Models;
using LibaryManagement.BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagement.BusinessObject
{
    public class BorrowBookObject
    {
        private static BorrowBookObject instance = null;
        private static readonly object instanceLock = new object();
        private BorrowBookObject() { }
        public static BorrowBookObject Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BorrowBookObject();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<BorrowBook> GetBorrowBookList()
        {
            List<BorrowBook> borrows;
            try
            {
                var myLibrary = new LibraryManagementContext();
                borrows = myLibrary.BorrowBooks.Include(s => s.Book).Include(s => s.Student).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return borrows;
        }
        public BorrowBook GetBorrowBook(string bookId, string studentId)
        {
            BorrowBook borrow = null;
            try
            {
                var myLibrary = new LibraryManagementContext();
                borrow = myLibrary.BorrowBooks.SingleOrDefault(borrow => borrow.BookId == bookId && borrow.StudentId == studentId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return borrow;
        }
        public void AddNew(BorrowBook borrow)
        {
            try
            {
                BorrowBook _b = GetBorrowBook(borrow.BookId, borrow.StudentId);
                if (_b == null)
                {
                    var myLibrary = new LibraryManagementContext();
                    myLibrary.BorrowBooks.Add(borrow);
                    myLibrary.SaveChanges();
                }
                else
                {
                    throw new Exception("The student is already borrow this book.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(BorrowBook borrow)
        {
            try
            {
                BorrowBook b = GetBorrowBook(borrow.BookId, borrow.StudentId);
                if (b != null)
                {
                    var myLibrary = new LibraryManagementContext();
                    myLibrary.Entry<BorrowBook>(borrow).State = EntityState.Modified;
                    myLibrary.SaveChanges();
                }
                else
                {
                    throw new Exception("The book does not borrow by this student.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Remove(BorrowBook borrow)
        {
            try
            {
                BorrowBook b = GetBorrowBook(borrow.BookId, borrow.StudentId);
                if (b != null)
                {
                    var myLibrary = new LibraryManagementContext();
                    myLibrary.BorrowBooks.Remove(borrow);
                    myLibrary.SaveChanges();
                }
                else
                {
                    throw new Exception("The book does not borrow by this student.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
