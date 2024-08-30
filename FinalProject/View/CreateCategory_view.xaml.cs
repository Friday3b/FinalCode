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
    /// Interaction logic for CreateCategory_view.xaml
    /// </summary>
    public partial class CreateCategory_view : Page
    {
        public CreateCategory_view()
        {
            InitializeComponent();
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





        private void LoadCategory_btn(object sender, RoutedEventArgs e)
        {
            try
            {
                // TextBox ve ComboBox'lardan bilgileri topla
                string categoryName = NameTextBox.Text;
                double? categoryQuantity = string.IsNullOrEmpty(QuantityTextBox.Text) ? (double?)null : Convert.ToDouble(QuantityTextBox.Text);
                string categoryDescription = DescriptionTextBox.Text;
                string categoryMedia = MediaTextBox.Text;
                

                // Yeni Product nesnesi oluştur
                Category newCategory = new Category
                {
                    Name = categoryName,
                    Quantity = Convert.ToInt32( categoryQuantity),
                    Description = categoryDescription,
                    MediaUrl = categoryMedia,
                    
                };

                // Veri tabanına ekle
                using (var context = new Database())
                {
                    context.Categories.Add(newCategory);

                    MessageBox.Show("added to Category");
                    try
                    {
                    context.SaveChanges();

                    }
                    catch (Exception exe)
                    {

                        MessageBox.Show($" second exp : {exe.Message}");
                    }
                }

                MessageBox.Show("Category successfully added.");
            }
           
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message + ex.InnerException);
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
