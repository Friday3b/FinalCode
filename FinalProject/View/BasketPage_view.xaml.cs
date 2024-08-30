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

namespace FinalProject.View
{
    /// <summary>
    /// Interaction logic for BasketPage_view.xaml
    /// </summary>
    public partial class BasketPage_view : Page
    {

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public BasketPage_view()
        {
            InitializeComponent();
            DataContext = this; 
            LoadBasketItems();

            
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            

                if (NavigationService.CanGoBack)
                {
                    NavigationService.GoBack();
                }
                
            
        }

        private void LoadBasketItems()
        {

            try
            {
                // Assuming the User ID is stored in Application.Current.Properties
                if (Application.Current.Properties["UsersId"] is int UserId)
                {
                    using (var context = new Database())
                    {
                        // Fetch the user's current order for the day
                        var order = context.Orders  ///<-- burda problem var bunu OrderItems elemek lazimdi ki ordan oxusun koda bax 
                            .FirstOrDefault(o => o.UsersId == UserId && o.Date == DateTime.Now.Date);

                       

                        //kodum bu kisma girmiyor burdada problem var direkt else ye gidiyor 
                        if (order != null)
                        {
                            var orderItems = context.OrderItems
                                .Where(oi => oi.OrdersId == order.Id)
                                .Select(oi => new OrderItem
                                {
                                    ProductName = oi.Product.Name,
                                    Quantity = oi.Quantity,
                                    TotalPrice = oi.Quantity * oi.Product.Price

                                })
                                .ToList();


                            this.DataContext = new
                            {
                                OrderItems = orderItems
                            };
                        }
                        else
                        {
                            MessageBox.Show("No items found in your basket.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User not found. Please Sign In.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured :{ex.Message}");
                
            }
        }






    }
}



//chatgbt

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Navigation;
//using FinalProject.AppDbContex;
//using FinalProject.Models;

//namespace FinalProject.View
//{
//    public partial class BasketPage_view : Page
//    {
//        public List<OrderItem> OrderItems { get; set; }

//        public BasketPage_view()
//        {
//            InitializeComponent();
//            DataContext = this;
//            LoadBasketItems();
//        }

//        private void BackButton_Click(object sender, RoutedEventArgs e)
//        {
//            if (NavigationService.CanGoBack)
//            {
//                NavigationService.GoBack();
//            }
//        }

//        private void LoadBasketItems()
//        {
//            // Assuming the User ID is stored in Application.Current.Properties
//            if (Application.Current.Properties["UsersId"] is int UserId)
//            {
//                using (var context = new Database())
//                {
//                    // Fetch the user's current order for the day
//                    var order = context.Orders
//                        .FirstOrDefault(o => o.UsersId == UserId && o.Date == DateTime.Now.Date);

//                    if (order != null)
//                    {
//                        // Fetch order items and populate the OrderItems property
//                        OrderItems = context.OrderItems
//                            .Where(oi => oi.OrdersId == order.Id)
//                            .Select(oi => new OrderItem
//                            {
//                                ProductName = oi.Product.Name, // Assuming OrderItem has this property
//                                Quantity = oi.Quantity,
//                                TotalPrice = oi.Quantity * oi.Product.Price // Assuming Product has a Price property
//                            })
//                            .ToList();

//                        // Set the DataContext to this page's instance to allow XAML bindings to access OrderItems
//                        DataContext = this;
//                    }
//                    else
//                    {
//                        MessageBox.Show("No items found in your basket.");
//                    }
//                }
//            }
//            else
//            {
//                MessageBox.Show("User not found. Please Sign In.");
//            }
//        }
//    }
//}
