using BCrypt.Net;
using LibaryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibaryManagement.BusinessObject
{
    public class UserObject
    {
        private static UserObject instance = null;
        private static readonly object instanceLock = new object();
        private static User? AccountLogin { get; set; }

        private UserObject() { }

        public static UserObject Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserObject();
                    }
                    return instance;
                }
            }
        }

        public User GetUserByID(int userId)
        {
            try
            {
                using (var context = new LibraryManagementContext())
                {
                    return context.Users.SingleOrDefault(users => users.UserId == userId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public User GetUserByUserName(string userName)
        {
            try
            {
                using (var context = new LibraryManagementContext())
                {
                    return context.Users.SingleOrDefault(users => users.UserName == userName);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UserLogin(string username, string password)
        {
            try
            {
                using (var context = new LibraryManagementContext())
                {
                    var user = context.Users.SingleOrDefault(u => u.UserName.Equals(username));
                    if (user != null && BCrypt.Net.BCrypt.Verify(password, user.UserPassword))
                    {
                        AccountLogin = user;
                        return user.RoleId; // Admin 1 || Staff 2
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 0;
        }

        public User GetAccountLogin()
        {
            return AccountLogin;
        }

        public List<User> GetUsers()
        {
            try
            {
                using (var context = new LibraryManagementContext())
                {
                    return context.Users.Include(u => u.Role).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateUser(User user)
        {
            try
            {
                using (var context = new LibraryManagementContext())
                {
                    var existingUser = context.Users.FirstOrDefault(u => u.UserId == user.UserId);
                    if (existingUser != null)
                    {
                        existingUser.RoleId = user.RoleId;
                        existingUser.UserPassword = BCrypt.Net.BCrypt.HashPassword(user.UserPassword);
                        context.Users.Update(existingUser);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AddUser(User user)
        {
            try
            {
                using (var context = new LibraryManagementContext())
                {
                    user.RoleId = 3;
                    user.UserPassword = BCrypt.Net.BCrypt.HashPassword(user.UserPassword);
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
