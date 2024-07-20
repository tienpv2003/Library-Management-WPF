using LibaryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagement.BusinessObject
{
    public class BookObject
    {
        private static BookObject instance = null;
        private static readonly object instanceLock = new object();
        private BookObject() { }
        public static BookObject Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookObject();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Book> GetBookList()
        {
            List<Book> books;
            try
            {
                var myLibrary = new LibraryManagementContext();
                books = myLibrary.Books.Include(b => b.Category).Include(b => b.Publisher).Include(b => b.Author).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return books;
        }
        public Book GetBookByID(string bookID)
        {
            Book book = null;
            try
            {
                var myLibrary = new LibraryManagementContext();
                book = myLibrary.Books.SingleOrDefault(book => book.BookId == bookID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return book;
        }
        public void AddNew(Book book)
        {
            try
            {
                Book _book = GetBookByID(book.BookId);
                if (_book == null)
                {
                    var myLibrary = new LibraryManagementContext();
                    myLibrary.Books.Add(book);
                    myLibrary.SaveChanges();
                }
                else
                {
                    throw new Exception("The Book is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Book book)
        {
            try
            {
                Book b = GetBookByID(book.BookId);
                if (b != null)
                {
                    var myLibrary = new LibraryManagementContext();
                    myLibrary.Entry<Book>(book).State = EntityState.Modified;
                    myLibrary.SaveChanges();
                }
                else
                {
                    throw new Exception("The Book does not exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Delete(Book book)
        {
            try
            {
                Book b = GetBookByID(book.BookId);
                if (b != null)
                {
                    var myLibrary = new LibraryManagementContext();
                    myLibrary.Books.Remove(book);
                    myLibrary.SaveChanges();
                }
                else
                {
                    throw new Exception("The Book does not exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
