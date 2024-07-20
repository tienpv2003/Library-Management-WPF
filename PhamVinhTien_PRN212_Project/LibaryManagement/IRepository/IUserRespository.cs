using LibaryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagement.IRepository
{
    public interface IUserRespository
    {
        public IEnumerable<User> GetUsers();
        public User GetUserByID(int userId);
        public void AddUser(User user);
        public void UpdadeUser(User user);
        public User getAccountLogin();
        public User getUserByUserName(string userName);
    }
}
