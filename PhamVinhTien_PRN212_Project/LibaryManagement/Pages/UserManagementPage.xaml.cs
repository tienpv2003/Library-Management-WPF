using LibaryManagement.IRepository;
using LibaryManagement.Models;
using LibaryManagement.Repository;
using LibaryManagement.Windows;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibaryManagement.Pages
{
    /// <summary>
    /// Interaction logic for UserManagementPage.xaml
    /// </summary>
    public partial class UserManagementPage : Page
    {
        IUserRespository userRespository;
        public UserManagementPage()
        {
            InitializeComponent();
            userRespository = new UserRepository();
            load();
        }

        private void load()
        {
            lvUsers.ItemsSource = userRespository.GetUsers();
        }

        private void btn_SearchClicked(object sender, RoutedEventArgs e)
        {
            var mylibrary = new LibraryManagementContext();
            IQueryable<User> usersIQ = from u in mylibrary.Users select u;
            if (rd_userid.IsChecked == true)
            {
                if (!String.IsNullOrEmpty(search_id.Text))
                {
                    int userId;
                    if (int.TryParse(search_id.Text, out userId))
                    {
                        usersIQ = usersIQ.Where(u => u.UserId == userId);
                    }
                    else
                    {
                        MessageBox.Show("Invalid User ID format.");
                    }
                }
            }
            if (rd_username.IsChecked == true)
            {
                if (!String.IsNullOrEmpty(search_user.Text))
                {
                    usersIQ = usersIQ.Where(u => u.UserName.Contains(search_user.Text));
                }
            }
            lvUsers.ItemsSource = usersIQ.Include(u => u.Role).ToList();
        }

        private void btn_RefreshClicked(object sender, RoutedEventArgs e)
        {
            rd_userid.IsChecked = false;
            rd_username.IsChecked = false;
            tbName.Text = "";
            tbUserId.Text = "";
            tbRole.Text = "";
            search_id.Text = "";
            search_user.Text = "";
            load();
        }
        private void btn_BanClicked(object sender, RoutedEventArgs e)
        {
            if (lvUsers.SelectedItem is User selectedUser)
            {
                MessageBoxResult result = MessageBox.Show($"Are you sure you want to ban {selectedUser.UserName}?", "Ban User", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    selectedUser.RoleId = 3; //set vao role guest

                    userRespository.UpdadeUser(selectedUser);
                    load(); 
                }
            }
            else
            {
                MessageBox.Show("Please select a user to ban.", "Ban User", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btn_EditStaffClicked(object sender, RoutedEventArgs e)
        {
            if (lvUsers.SelectedItem is User selectedUser)
            {
                EditRoleWindow editRole = new EditRoleWindow(selectedUser);
                if (editRole.ShowDialog() == true)
                {
                    userRespository.UpdadeUser(editRole.user);
                    load();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to set role.", "Edit User", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
