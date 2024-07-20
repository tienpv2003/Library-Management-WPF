using LibaryManagement.BusinessObject;
using LibaryManagement.IRepository;
using LibaryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagement.Repository
{
    public class UserRepository : IUserRespository
    {
        public int UserLogin(string username, string password) =>
            UserObject.Instance.UserLogin(username, password);
        public IEnumerable<User> GetUsers() => UserObject.Instance.GetUsers();
        public void AddUser(User user) => UserObject.Instance.AddUser(user);
        public User getAccountLogin() => UserObject.Instance.GetAccountLogin();
        public void UpdadeUser(User user) => UserObject.Instance.UpdateUser(user);
        public User getUserByUserName(string userName) => UserObject.Instance.GetUserByUserName(userName);
        public User GetUserByID(int userId) => UserObject.Instance.GetUserByID(userId);
    }
}
