using LibaryManagement.Models;
using LibaryManagement.Pages;
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

namespace LibaryManagement.Windows
{
    /// <summary>
    /// Interaction logic for StaffWindow.xaml
    /// </summary>
    public partial class StaffWindow : Window
    {
        Page homePage;
        Page bookManagementPage;
        Page readerManagementPage;
        Page borrowBookPage;
        Page publisherManagementPage;
        Page authorBookPage;
        Page statisticPage;
        public StaffWindow()
        {
            InitializeComponent();
            homePage = new HomePage();
            bookManagementPage = new BookManagementPage();
            readerManagementPage = new ReaderManagementPage();
            borrowBookPage = new BorrowBookPage();
            publisherManagementPage = new PublisherManagementPage();
            authorBookPage = new AuthorManagementPage();
            statisticPage = new StatisticPage();

            navFrame.Navigate(homePage);
            sidebar.SelectedIndex = 0;
        }
        private void sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (sidebar.SelectedIndex)
            {
                case 0:
                    navFrame.Navigate(homePage);
                    break;
                case 1:
                    navFrame.Navigate(bookManagementPage);
                    break;
                case 2:
                    navFrame.Navigate(readerManagementPage);
                    break;
                case 3:
                    navFrame.Navigate(publisherManagementPage);
                    break;
                case 4:
                    navFrame.Navigate(authorBookPage);
                    break;
                case 5:
                    navFrame.Navigate(borrowBookPage);
                    break;
                case 6:
                    navFrame.Navigate(statisticPage);
                    break;
            }
        }
        private void navFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfileStaffWindow profileStaffWindow = new ProfileStaffWindow();   
            profileStaffWindow.Show();
            this.Close();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
