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
    /// Interaction logic for AdminPanel_view.xaml
    /// </summary>
    public partial class AdminPanel_view : Page
    {
        public AdminPanel_view()
        {
            InitializeComponent();
        }

        private void create_category_button(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateCategory_view());

        }

        private void create_product_button(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateProduct_view());
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
