using FinalProject.Models;
using Microsoft.Data.SqlClient;
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
using System.Globalization;
using FinalProject.ViewModel;
using Microsoft.EntityFrameworkCore;
using FinalProject.AppDbContex;

namespace FinalProject.View
{
    /// <summary>
    /// Interaction logic for UserProfile_view.xaml
    /// </summary>
    public partial class UserProfile_view : Page
    {

        public UserProfile_view(string email, string password)
        {
            InitializeComponent();


            if (Application.Current.Properties.Contains("SharedData"))
            {
                var sharedData = (SharedDataModel)Application.Current.Properties["SharedData"];
                creditecart_textblock.Text = sharedData.CreditCardInfo;
            }




            var user = GetUserByEmailAndPassword(email, password);

            if (user != null)
            {
                
                nameofuser_textblock.Text = $"Name: {user.Name}, Surname: {user.Surname}";

                Application.Current.Properties["UsersId"] = user.Id;
            }
            else
            {
                MessageBox.Show("User information doesnt find ");
            }
        }



        private User GetUserByEmailAndPassword(string email, string password)
        {
            using (var context = new Database())
            {
                try
                {
                    var user = context.Users
                                      .FirstOrDefault(u => u.Email == email && u.Password == password);
                    return user;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error accured , while take info about user : " + ex.Message);
                    return null;
                }
            }
        }




        private void add_card_btn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new register_cart_view());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Edit_profile_view());

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {


            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }


        }

        private void delete_card_btn(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Properties.Contains("UsersId"))
            {
                int currentUserId = (int)Application.Current.Properties["UsersId"];

                try
                {
                    DeleteCardFromDatabase(currentUserId);
                    creditecart_textblock.Text = "Credit Cards"; 
                    MessageBox.Show("Card deleted successfully.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Couldn't find user information, please sign up again.");
            }


        }

        private void DeleteCardFromDatabase(int userId)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-G936QCF;Initial Catalog=FINAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Cards WHERE UsersId = @UsersId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UsersId", userId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No card found for the current user.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



    }


    public class SharedDataModel
    {
        public string CreditCardInfo { get; set; }
    }

}
