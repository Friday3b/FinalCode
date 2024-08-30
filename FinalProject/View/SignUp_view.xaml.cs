using FinalProject.AppDbContex;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace FinalProject.View
{
    /// <summary>
    /// Interaction logic for SignIn_view.xaml
    /// </summary>
    public partial class SignUp_view : Page
    {
        public SignUp_view()
        {
            InitializeComponent();
            this.DataContext = new User();
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

        private void signup_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(SurnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordTextBox.Text) ||
                !DataPicker.SelectedDate.HasValue ||
                (MaleRadioButton.IsChecked == false && FemaleRadioButton.IsChecked == false))
                {
                        MessageBox.Show("Please fill in all the required fields ! ");
                        return;
                }



                User user1 = new User
                {
                    Name = NameTextBox.Text,
                    Surname = SurnameTextBox.Text,
                    DateOfBirth = DataPicker.SelectedDate,
                    Email = EmailTextBox.Text,
                    Password = PasswordTextBox.Text,
                    Gender = MaleRadioButton.IsChecked == true ? "Male" : "Female"

                    

                };

                

                using (var context = new Database())
                {
                    context.Users.Add(user1);
                    context.SaveChanges();
                    

                }

                MessageBox.Show("User registered Successfully");

                int userId = user1.Id;
                Application.Current.Properties["UsersId"] = userId;

                NavigationService.Navigate(new myprofile_view());

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error : {ex.Message} ");
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
