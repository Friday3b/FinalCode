using FinalProject.Models;
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
using FinalProject.AppDbContex;

namespace FinalProject.View
{
    /// <summary>
    /// Interaction logic for CreateProduct_view.xaml
    /// </summary>
    public partial class CreateProduct_view : Page
    {
        public CreateProduct_view()
        {
            InitializeComponent();
            LoadCategories();
        }


        #region gotfocus , lostfocus


        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Tag is TextBlock placeholder)
            {
                placeholder.Visibility = Visibility.Hidden;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Tag is TextBlock placeholder)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    placeholder.Visibility = Visibility.Visible;
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Tag is TextBlock placeholder)
            {
                if (!string.IsNullOrEmpty(textBox.Text))
                {
                    placeholder.Visibility = Visibility.Hidden;
                }
            }
        }









        #endregion



        private void LoadCategories()
        {

            using (var contex = new Database())
            {

                var categories = contex.Categories.ToList();
                ProductCategoryComboBox.ItemsSource = categories;
                ProductCategoryComboBox.DisplayMemberPath = "Name";
                ProductCategoryComboBox.SelectedValuePath = "Id";

            }
        }



        private void LoadProduct_btn(object sender, RoutedEventArgs e)
            {
                try
                {
                    // TextBox ve ComboBox'lardan bilgileri topla
                    string productName = NameTextBox.Text;
                    double? productQuantity = string.IsNullOrEmpty(QuantityTextBox.Text) ? (double?)null : Convert.ToDouble(QuantityTextBox.Text);
                    string productDescription = DescriptionTextBox.Text;
                    string productMedia = MediaTextBox.Text;
                    int selectedCategoryId = (int)ProductCategoryComboBox.SelectedValue;
                    int? productPrice = string.IsNullOrEmpty(ProductPriceTextBox.Text) ? (int?)null : Convert.ToInt32(ProductPriceTextBox.Text);

                    // Yeni Product nesnesi oluştur
                    Product newProduct = new Product
                    {
                        Name = productName,
                        Quanttity = productQuantity,
                        Description = productDescription,
                        Media = productMedia,
                        CategoryId = selectedCategoryId,
                        Price = productPrice
                    };

                    // Veri tabanına ekle
                    using (var context = new Database())
                    {
                        context.Products.Add(newProduct);
                        context.SaveChanges();
                    }

                    MessageBox.Show("Product successfully added.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }















            
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
