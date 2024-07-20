using LibaryManagement.BusinessObject;
using LibaryManagement.IRepository;
using LibaryManagement.Models;
using System.Collections.Generic;

namespace LibaryManagement.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        public void AddPublisher(Publisher publisher) => PublisherObject.Instance.AddPublisher(publisher);
        public void DeletePublisher(string publisherId) => PublisherObject.Instance.DeletePublisher(publisherId);
        public void UpdadePublisher(Publisher publisher) => PublisherObject.Instance.UpdatePublisher(publisher);

        Publisher IPublisherRepository.GetPublisherByID(string publisher) => PublisherObject.Instance.GetPublisherByID(publisher);
        IEnumerable<Publisher> IPublisherRepository.GetPublishers() => PublisherObject.Instance.GetPublisherList();
    }
}
