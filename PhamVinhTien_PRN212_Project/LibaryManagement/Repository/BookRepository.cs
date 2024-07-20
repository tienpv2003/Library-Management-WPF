using LibaryManagement.BusinessObject;
using LibaryManagement.IRepository;
using LibaryManagement.Models;
using System.Collections.Generic;

namespace LibaryManagement.Repository
{
    public class BookRepository : IBookRepository
    {
        public Book GetBookByID(string bookId) => BookObject.Instance.GetBookByID(bookId);

        public IEnumerable<Book> GetBooks() => BookObject.Instance.GetBookList();

        public void InsertBook(Book book) => BookObject.Instance.AddNew(book);

        public void UpdateBook(Book book) => BookObject.Instance.Update(book);
    }
}
