using LibaryManagement.Models;
using LibaryManagement.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibaryManagement.BusinessObject
{
    public class PublisherObject
    {
        private static PublisherObject instance = null;
        private static readonly object instanceLock = new object();
        private PublisherObject() { }
        public static PublisherObject Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new PublisherObject();
                    }
                    return instance;
                }
            }
        }
        public Publisher GetPublisherByID(string publisherId)
        {
            Publisher publisher = null;
            try
            {
                var myLibrary = new LibraryManagementContext();
                publisher = myLibrary.Publishers.SingleOrDefault(publisher => publisher.PublisherId == publisherId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return publisher;
        }
        public IEnumerable<Publisher> GetPublisherList()
        {
            List<Publisher> publishers;
            try
            {
                var myLibrary = new LibraryManagementContext();
                publishers = myLibrary.Publishers.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return publishers;
        }
        public void AddPublisher(Publisher publisher)
        {
            try
            {
                Publisher _publisher = GetPublisherByID(publisher.PublisherId);
                if (_publisher == null)
                {
                    var myLibrary = new LibraryManagementContext();
                    myLibrary.Publishers.Add(publisher);
                    myLibrary.SaveChanges();
                }
                else
                {
                    throw new Exception("The Publisher is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdatePublisher(Publisher publisher)
        {
            try
            {
                using (var myLibrary = new LibraryManagementContext())
                {
                    var existingPublisher = myLibrary.Publishers.FirstOrDefault(p => p.PublisherId == publisher.PublisherId);
                    if (existingPublisher != null)
                    {
                        existingPublisher.PublisherName = publisher.PublisherName;
                        myLibrary.Entry(existingPublisher).State = EntityState.Modified;
                        myLibrary.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("The Publisher does not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating Publisher: {ex.Message}");
            }
        }
        public void DeletePublisher(string publisherId)
        {
            try
            {
                using (var myLibrary = new LibraryManagementContext())
                {
                    var publisher = myLibrary.Publishers.FirstOrDefault(p => p.PublisherId == publisherId);
                    if (publisher != null)
                    {
                        myLibrary.Publishers.Remove(publisher);
                        myLibrary.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("The publisher does not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting publisher: {ex.Message}");
            }
        }
    }
}
