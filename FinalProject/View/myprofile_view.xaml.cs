using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// Interaction logic for myprofile_view.xaml
    /// </summary>
    public partial class myprofile_view : Page 
    {
        public myprofile_view()
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

        #region Password#


        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var passwordBox = sender as PasswordBox;
            var placeholder = passwordBox.Tag as TextBlock;
            placeholder.Visibility = Visibility.Collapsed;
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var passwordBox = sender as PasswordBox;
            var placeholder = passwordBox.Tag as TextBlock;
            if (string.IsNullOrEmpty(passwordBox.Password))
            {
                placeholder.Visibility = Visibility.Visible;
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = sender as PasswordBox;
            var placeholder = passwordBox.Tag as TextBlock;
            if (!string.IsNullOrEmpty(passwordBox.Password))
            {
                placeholder.Visibility = Visibility.Collapsed;
            }
        }

        #endregion



        private int GetUserIdFromDatabase(string email, string password)
        {
            int userId = -1;
            string connectionString = "Data Source=DESKTOP-G936QCF;Initial Catalog=FINAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            string query = "SELECT Id FROM Users WHERE Email=@Email AND Password=@Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    userId = Convert.ToInt32(result);
                }
            }

            return userId;
        }





        private void signup_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignUp_view());
           
        }

        private void signin_click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(EmailTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Password))
                {
                   
                    MessageBox.Show("Email and password cannot be empty.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);

                    return; 
                }

                string connectionstring = "Data Source=DESKTOP-G936QCF;Initial Catalog=FINAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

                string query_signin = "SELECT COUNT(*) FROM Users WHERE Email=@Email AND Password=@Password ";

                using (SqlConnection connection = new SqlConnection(connectionstring)) {
                
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query_signin, connection))
                    {

                        command.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                        command.Parameters.AddWithValue("@Password" , PasswordTextBox.Password);



                        object userIdObj = command.ExecuteScalar();
                        if (userIdObj != null) 
                        {
                            int userId  = Convert.ToInt32(userIdObj);

                            Application.Current.Properties["UsersId"] = userId;

                            MessageBox.Show("Id has keeped in global ");
                        }




                        
                        int userCOUNT = (int)command.ExecuteScalar();

                        if (userCOUNT > 0)
                        {

                            int userId = GetUserIdFromDatabase(EmailTextBox.Text ,PasswordTextBox.Password);
                            Application.Current.Properties["UsersId"] = userId;


                            NavigationService.Navigate(new UserProfile_view(EmailTextBox.Text , PasswordTextBox.Password));
                            UserProfile_view user = new UserProfile_view(EmailTextBox.Text, PasswordTextBox.Password);


                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password ", "Sign in Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }

                    }

                
                }





                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
