using LibaryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagement.IRepository
{
    public interface IAuthorRepository
    {
        public IEnumerable<Author> GetAuthors();
        public Author GetAuthorByID(string authorId);
        public void AddAuthor(Author author);
        public void UpdateAuthor(Author author);
        public void DeleteAuthor(string AuthorId);
    }
}
