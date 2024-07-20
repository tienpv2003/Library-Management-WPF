using LibaryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibaryManagement.BusinessObject
{
    public class AuthorObject
    {
        private static AuthorObject instance = null;
        private static readonly object instanceLock = new object();
        private AuthorObject() { }
        public static AuthorObject Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AuthorObject();
                    }
                    return instance;
                }
            }
        }
        public Author GetAuthorByID(string authorId)
        {
            Author author = null;
            try
            {
                var myLibrary = new LibraryManagementContext();
                author = myLibrary.Authors.SingleOrDefault(author => author.AuthorId == authorId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return author;
        }
        public IEnumerable<Author> GetAuthorList()
        {
            List<Author> authors;
            try
            {
                var myLibrary = new LibraryManagementContext();
                authors = myLibrary.Authors.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return authors;
        }
        public void AddAuthor(Author author)
        {
            try
            {
                Author _author = GetAuthorByID(author.AuthorId);
                if (_author == null)
                {
                    var myLibrary = new LibraryManagementContext();
                    myLibrary.Authors.Add(author);
                    myLibrary.SaveChanges();
                }
                else
                {
                    throw new Exception("The author is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateAuthor(Author author)
        {
            try
            {
                using (var myLibrary = new LibraryManagementContext())
                {
                    var existingAuthor = myLibrary.Authors.FirstOrDefault(s => s.AuthorId == author.AuthorId);
                    if (existingAuthor != null)
                    {
                        existingAuthor.AuthorName = author.AuthorName;
                        myLibrary.Entry(existingAuthor).State = EntityState.Modified;
                        myLibrary.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("The author does not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating author: {ex.Message}");
            }
        }
        public void DeleteAuthor(string authorId)
        {
            try
            {
                using (var myLibrary = new LibraryManagementContext())
                {
                    var author = myLibrary.Authors.FirstOrDefault(s => s.AuthorId == authorId);
                    if (author != null)
                    {
                        myLibrary.Authors.Remove(author);
                        myLibrary.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("The author does not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting author: {ex.Message}");
            }
        }
    }
}
