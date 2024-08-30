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


namespace FinalProject.View
{
    /// <summary>
    /// Interaction logic for register_cart_view.xaml
    /// </summary>
    public partial class register_cart_view : Page
    {
        public register_cart_view()
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









        private void Save_button(object sender, RoutedEventArgs e)
        {

            try
            {
                string cardNumber = FinTextBox.Text;
                string cardDate = ExpireTextBox.Text;
                string cardCvc = CVCTextBox.Text;

                if (Application.Current.Properties.Contains("UsersId"))
                {
                    int currentUserId = (int)Application.Current.Properties["UsersId"];


                    Card card = new Card()
                    {
                        Items = $"{cardNumber} , {cardDate} , {cardCvc}",
                        UsersId = currentUserId,


                    };

                    SaveCardToDatabase(card);
                    
                    
                    
                    //_______________________________________________________
                    var sharedData = new SharedDataModel
                    {
                        CreditCardInfo = $"{cardNumber}, {cardDate}, {cardCvc}"
                    };


                    Application.Current.Properties["SharedData"] = sharedData;


                    //________________________________________________________
                    MessageBox.Show("Card Saved");

                }
                else
                {
                    MessageBox.Show("Doesnt find User information , please again SignUp ");
                }



            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error :  " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem accured : " + ex.Message);
            }



        }



        private void SaveCardToDatabase(Card card)
        {

            try
            {
                string connectionString = "Data Source=DESKTOP-G936QCF;Initial Catalog=FINAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    string query = "INSERT INTO Cards(UsersId,Items) VALUES (@UsersId,@Items)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UsersId", card.UsersId);
                    command.Parameters.AddWithValue("@Items", card.Items);

                    command.ExecuteNonQuery();

                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error Database:" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accured: " + ex.Message);
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
