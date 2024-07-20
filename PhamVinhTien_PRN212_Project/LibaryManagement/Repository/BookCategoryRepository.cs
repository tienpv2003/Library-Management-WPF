using LibaryManagement.BusinessObject;
using LibaryManagement.IRepository;
using LibaryManagement.Models;
using System.Collections.Generic;

namespace LibaryManagement.Repository
{
    public class BookCategoryRepository : IBookCategoryRepository
    {
        public IEnumerable<BookCategory> GetBookCategories() => BookCategoryObject.Instanc.GetBookCategoryList();

        public BookCategory GetBookCategoryByID(int categoryId) => BookCategoryObject.Instanc.GetBookCategoryByID(categoryId);
    }
}
