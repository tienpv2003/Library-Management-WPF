using LibaryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagement.BusinessObject
{
    public class BookCategoryObject
    {
        private static BookCategoryObject instance = null;
        private static readonly object instanceLock = new object();
        private BookCategoryObject() { }
        public static BookCategoryObject Instanc
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookCategoryObject();
                    }
                    return instance;
                }
            }
        }
        public BookCategory GetBookCategoryByID(int categoryId)
        {
            BookCategory category = null;
            try
            {
                var myLibrary = new LibraryManagementContext();
                category = myLibrary.BookCategories.SingleOrDefault(category => category.CategoryId == categoryId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return category;
        }
        public IEnumerable<BookCategory> GetBookCategoryList()
        {
            List<BookCategory> categories;
            try
            {
                var myLibrary = new LibraryManagementContext();
                categories = myLibrary.BookCategories.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return categories;
        }
    }
}
