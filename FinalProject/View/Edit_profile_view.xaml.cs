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
using FinalProject.Models;
using Microsoft.Identity.Client.NativeInterop;


namespace FinalProject.View
{
    /// <summary>
    /// Interaction logic for Edit_profile_view.xaml
    /// </summary>
    public partial class Edit_profile_view : Page
    {
        public Edit_profile_view()
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

















        private void UpdateUser(User user)
        {
            using (var contex = new Database())
            {
                try
                {

                    contex.Users.Update(user);
                    contex.SaveChanges();
                    MessageBox.Show("User updated successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while update User info" + ex.Message);


                }




            }
        }




            private void Save_edit_click(object sender, RoutedEventArgs e)
            {

                var updateUser = new User
                {
                    Id = (int)Application.Current.Properties["UsersId"],
                    Name = NameTextBox.Text,
                    Surname = SurnameTextBox.Text,
                    Email = EmailTextBox.Text,
                    Password = PasswordTextBox.Text,



                };

                UpdateUser(updateUser);

            

                



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