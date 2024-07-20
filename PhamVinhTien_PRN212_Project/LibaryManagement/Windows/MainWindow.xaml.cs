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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Page homePage;
        Page userManagementPage;
        Page bookManagementPage;
        Page readerManagementPage;
        Page borrowBookPage;
        Page publisherManagementPage;
        Page authorBookPage;
        Page statisticPage;
        public MainWindow()
        {
            InitializeComponent();
            homePage = new HomePage();
            bookManagementPage = new BookManagementPage();
            userManagementPage = new UserManagementPage();
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
                    navFrame.Navigate(userManagementPage);
                    break;
                case 2:
                    navFrame.Navigate(bookManagementPage);
                    break;
                case 3:
                    navFrame.Navigate(readerManagementPage);
                    break;
                case 4:
                    navFrame.Navigate(publisherManagementPage);
                    break;
                case 5:
                    navFrame.Navigate(authorBookPage);
                    break;
                case 6:
                    navFrame.Navigate(borrowBookPage);
                    break;
                case 7:
                    navFrame.Navigate(statisticPage);
                    break;
            }
        }

        private void navFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
