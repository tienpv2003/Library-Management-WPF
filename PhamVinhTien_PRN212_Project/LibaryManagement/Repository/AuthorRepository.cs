using LibaryManagement.BusinessObject;
using LibaryManagement.IRepository;
using LibaryManagement.Models;
using System.Collections.Generic;

namespace LibaryManagement.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        public void AddAuthor(Author author) => AuthorObject.Instance.AddAuthor(author);

        public void DeleteAuthor(string AuthorId) => AuthorObject.Instance.DeleteAuthor(AuthorId);

        public void UpdateAuthor(Author author) => AuthorObject.Instance.UpdateAuthor(author);

        Author IAuthorRepository.GetAuthorByID(string authorId) => AuthorObject.Instance.GetAuthorByID(authorId);
        IEnumerable<Author> IAuthorRepository.GetAuthors() => AuthorObject.Instance.GetAuthorList();
    }
}
