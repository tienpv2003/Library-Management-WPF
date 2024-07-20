using LibaryManagement.IRepository;
using LibaryManagement.Models;
using LibaryManagement.Repository;
using LibaryManagement.Windows;
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
    /// Interaction logic for PublisherManagementPage.xaml
    /// </summary>
    public partial class PublisherManagementPage : Page
    {
        private readonly LibraryManagementContext _context;
        IPublisherRepository _publisherRepository;
        public Publisher Publisher { get; set; }
        public PublisherManagementPage()
        {
            InitializeComponent();
            _context = new LibraryManagementContext();
            _publisherRepository = new PublisherRepository();
            Loaded += Window_Load;

        }
        private void load()
        {
            lvPublishers.ItemsSource = _context.Publishers.ToList();
        }
        private void Window_Load(object sender, RoutedEventArgs e)
        {
            load();
        }
        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbPublisherId.Text) || string.IsNullOrWhiteSpace(tbPublisherName.Text))
                {
                    throw new Exception("All fields are required!");
                }
                Publisher newPublisher = new Publisher
                {
                    PublisherId = tbPublisherId.Text,
                    PublisherName = tbPublisherName.Text
                };
                var existingAuthor = _publisherRepository.GetPublisherByID(tbPublisherId.Text);
                if (existingAuthor != null)
                {
                    throw new Exception("PublisherID already exists!");
                }
                _publisherRepository.AddPublisher(newPublisher);
                load();
                MessageBox.Show("Add Publisher successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Publisher");
            }
        }
        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            if (lvPublishers.SelectedItem is Publisher selectedPublisher)
            {
                EditPublisher editPublisher = new EditPublisher(selectedPublisher);
                if (editPublisher.ShowDialog() == true)
                {
                    _publisherRepository.UpdadePublisher(editPublisher.Publisher);
                    load();
                }
            }
            else
            {
                MessageBox.Show("Please select a Publisher to edit.", "Edit Publisher", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (lvPublishers.SelectedItem is Publisher selectedPublisher)
            {
                MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete {selectedPublisher.PublisherName}?", "Delete Publisher", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    _publisherRepository.DeletePublisher(selectedPublisher.PublisherId);
                    load();
                }
            }
            else
            {
                MessageBox.Show("Please select a Publisher to delete.", "Delete Publisher", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btn_Refresh_Click(object sender, RoutedEventArgs e)
        {
            tbPublisherId.Text = "";
            tbPublisherName.Text = "";
        }
    }
}
