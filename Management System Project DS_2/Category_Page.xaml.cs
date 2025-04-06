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

namespace Management_System_Project_DS_2
{
    /// <summary>
    /// Interaction logic for Category_Page.xaml
    /// </summary>
    public partial class Category : Window
    {
        public Category()
        {
            InitializeComponent();
        }

        private void AddCategory_Click(object sender, RoutedEventArgs e)
        {
            PopupOverlay.Visibility = Visibility.Visible;

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string newCategory = CategoryNameTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(newCategory))
            {
                MessageBox.Show($"Category '{newCategory}' Added Successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                // Yahan apni logic lagayein to add it to database or datagrid
                CategoryNameTextBox.Text = "";
                PopupOverlay.Visibility = Visibility.Collapsed;
            }
            else
            {
                MessageBox.Show("Please enter a product name.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void Discard_Click(object sender, RoutedEventArgs e)
        {
            PopupOverlay.Visibility = Visibility.Collapsed;
            CategoryNameTextBox.Text = "";
        }
    }
}
