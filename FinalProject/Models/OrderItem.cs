using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class OrderItem :INotifyPropertyChanged
    {
        
        public int Id { get; set; }


        private string ? _productname;

        public string ? ProductName
        {
            get { return _productname; }
            set { _productname = value; }
        }



        private int? _quantity;

        public int? Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }



        private double? _totalprice;

        public double? TotalPrice
        {
            get { return _totalprice; }
            set { _totalprice = value; }
        }

        


        [ForeignKey("Product")]
        public int ProductsId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Order")]
        public int OrdersId { get; set; }
        public Order Order { get; set; }
        

        
        
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
