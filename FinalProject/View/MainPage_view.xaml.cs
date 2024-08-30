using FinalProject.AppDbContex;
using FinalProject.Models;
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
using FinalProject.View;

namespace FinalProject.View
{
    /// <summary>
    /// Interaction logic for MainPage_view.xaml
    /// </summary>
    public partial class MainPage_view : Page
    {
        public MainPage_view()
        {
            InitializeComponent();

            LoadCategories();






            var items1 = new List<Product>();
            var items2 = new List<Product>();
            var items3 = new List<Product>();
            var items4 = new List<Product>();
            var items5 = new List<Product>();
            var items6 = new List<Product>();
            var items7 = new List<Product>();
            var items8 = new List<Product>();




            product_listview1.ItemsSource = items1;
            product_listview2.ItemsSource = items2;
            product_listview3.ItemsSource = items3;
            product_listview4.ItemsSource = items4;
            product_listview5.ItemsSource = items5;
            product_listview6.ItemsSource = items6;
            product_listview7.ItemsSource = items7;
            product_listview8.ItemsSource = items8;







            var cg1 = new Category { Id = 1, Name = "Mall" };
            var cg2 = new Category { Id = 2, Name = "Sosial Platform" };
            var cg3 = new Category { Id = 3, Name = "Electrinics" };
            var cg4 = new Category { Id = 4, Name = "Homegoods" };
            var cg5 = new Category { Id = 5, Name = "Wears" };
            var cg6 = new Category { Id = 6, Name = "Plates" };
            var cg7 = new Category { Id = 7, Name = "Toys" };
            var cg8 = new Category { Id = 8, Name = "Machines" };




            var product1 = new Product { Name = "Nazim Hikmet", Id = 2, Price = 150, category = cg1, Media = "C:\\Users\\Taleh\\source\\repos\\FinalProject\\Icons\\pngtree-instagram-social-media-icon-png-image_3572487.jpg" };
            items1.Add(product1);
            
            


            var product2 = new Product { Name = "Nizami Nezm Nazim", Id = 4, Price = 300, category = cg2, Media = "C:\\Users\\Taleh\\source\\repos\\FinalProject\\Icons\\PNG_transparency_demonstration_1.png" };
            items2.Add(product2);

            var product3 = new Product { Name = "Shandelier", Id = 5, Price = 400, category = cg3, Media = "C:\\Users\\Taleh\\source\\repos\\FinalProject\\Icons\\png-transparent-spider-man-heroes-download-with-transparent-background-free-thumbnail.png" };
            items3.Add(product3);

            var product4 = new Product { Name = "Socket", Id = 7, Price = 500, category = cg4, Media = "C:\\Users\\Taleh\\source\\repos\\FinalProject\\Icons\\png-clipart-free-pic-web-design-label-thumbnail.png" };
            items4.Add(product4);

            var product5 = new Product { Name = "T-shirt", Id = 8, Price = 100, category = cg5, Media = "C:\\Users\\Taleh\\source\\repos\\FinalProject\\Icons\\images.png" };
            items5.Add(product5);

            var product6 = new Product { Name = "Bowl", Id = 9, Price = 50, category = cg6, Media = "C:\\Users\\Taleh\\source\\repos\\FinalProject\\Icons\\download.jpeg" };
            items6.Add(product6);

            var product7 = new Product { Name = "Doll", Id = 10, Price = 120, category = cg7, Media = "C:\\Users\\Taleh\\source\\repos\\FinalProject\\Icons\\images.jpeg" };
            items7.Add(product7);

            var product8 = new Product { Name = "Robocop", Id = 11, Price = 700, category = cg8, Media = "C:\\Users\\Taleh\\source\\repos\\FinalProject\\Icons\\robocop-helmet-robot-head-B5wkdnA-600.jpg" };
            items8.Add(product8);

           

        }









        #region 3 buttons



        private void basket_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new BasketPage_view());

        }

        private void myprofile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new myprofile_view());
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();


        }
        #endregion



        #region LoadCategoriesComboBox



        private void LoadCategories()
        {
            try
            {
                using (var context = new Database())
                {
                    var categories = context.Categories.ToList();

                    if (categories.Any())
                    {
                        categories_of_combobox.ItemsSource = categories;
                        categories_of_combobox.DisplayMemberPath = "Name";
                        categories_of_combobox.SelectedValuePath = "Id"; // Seçili öğenin ID'sini almak için
                    }
                    else
                    {
                        MessageBox.Show("No categories found in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}");
            }
        }

        #endregion



        #region Add to cart button



        private void AddToBasketeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var button = sender as Button;
                var product = button.DataContext as Product;

                if (product == null)
                {
                    MessageBox.Show("Product not found");
                    return;
                }

                using (var context = new Database())
                {
                    var existingProduct = context.Products.FirstOrDefault(p => p.Id == product.Id);
                    if (existingProduct == null)
                    {
                        // Ürün veritabanında yoksa hata verin veya ekleyin
                        MessageBox.Show("Product not found in the database.");
                        return;
                    }

                    if (Application.Current.Properties["UsersId"] is int UserId)
                    {
                        // Fetch the user's current order for the day
                        var order = context.Orders
                            .FirstOrDefault(o => o.UsersId == UserId && o.Date == DateTime.Now.Date);

                        if (order == null)
                        {
                            // Create a new order if none exists
                            order = new Order
                            {
                                
                                UsersId = UserId,
                                Date = DateTime.Now,
                                OrderItems = new List<OrderItem>()
                            };
                            context.Orders.Add(order);
                            context.SaveChanges();
                        }

                        // Check if the product is already in the order
                        var orderItem = context.OrderItems
                            .FirstOrDefault(oi => oi.OrdersId == order.Id && oi.ProductsId == product.Id);

                        if (orderItem != null)
                        {
                            orderItem.Quantity++;
                        }
                        else
                        {
                            orderItem = new OrderItem
                            {
                                ProductName = product.Name,
                                TotalPrice = product.Price,
                                ProductsId = product.Id,
                                Quantity = 1,
                                OrdersId = order.Id,
                            };
                            context.OrderItems.Add(orderItem);
                        }

                        context.SaveChanges();

                        MessageBox.Show($"Product '{product.Name}' added to your basket.");

                       
                    }
                    else
                    {
                        MessageBox.Show("User not found. Please Sign In.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message + " Detailed exception: " + ex.InnerException?.Message);
            }
        }


        private void admin_panel_button(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new AdminPanel_view());

        }

        #endregion









    }
}

    

