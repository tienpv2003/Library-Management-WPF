using LibaryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagement.IRepository
{
    public interface IPublisherRepository
    {
        public IEnumerable<Publisher> GetPublishers();
        public Publisher GetPublisherByID(string publisher);
        public void AddPublisher(Publisher publisher);
        public void UpdadePublisher(Publisher publisher);
        public void DeletePublisher(string publisherId);
    }
}
