using LibaryManagement.BusinessObject;
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
using System.Windows.Shapes;

namespace LibaryManagement.Windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = txtUser.Text;
                string password = txtPass.Password;

                int loginResult = UserObject.Instance.UserLogin(name, password);

                if (loginResult == 1) // Admin
                {
                    MainWindow _mainWindow = new MainWindow();
                    _mainWindow.Show();
                    this.Close();
                }
                else if (loginResult == 2) // Staff
                {
                    StaffWindow _staffWindow = new StaffWindow();
                    _staffWindow.Show();
                    this.Close();
                }
                else // Login failed
                {
                    MessageBox.Show("Login failed, Login Again", "Login");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed, Login Again", "Login");
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterStaffWindow registerStaffWindow = new RegisterStaffWindow();
            registerStaffWindow.Show();
            this.Close();
        }

        private void btnForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Close();
        }
    }
}
