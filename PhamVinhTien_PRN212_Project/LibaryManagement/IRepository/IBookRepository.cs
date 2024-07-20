using LibaryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagement.IRepository
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetBooks();
        public Book GetBookByID(string bookId);
        public void InsertBook(Book book);
        public void UpdateBook(Book book);
    }
}
