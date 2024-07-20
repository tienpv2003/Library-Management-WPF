using LibaryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagement.IRepository
{
    public interface IBookCategoryRepository
    {
        public IEnumerable<BookCategory> GetBookCategories();
        public BookCategory GetBookCategoryByID(int categoryId);
    }
}
