using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Product :INotifyPropertyChanged
    {

        public int Id { get; set; }


        private string? _name;

        public string? Name
        {
            get { return _name; }
            set { _name = value;  OnPropertyChanged(); }
        }


        private double? _quantity;

        public double ?Quanttity
        {
            get { return _quantity; }
            set { _quantity = value; OnPropertyChanged(); }
        }

        private string? _description;

        public string? Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged(); }
        }


        private string? _media;

        public string? Media
        {
            get { return _media; }
            set { _media = value; OnPropertyChanged(); }
        }


        

        [ForeignKey(nameof(CategoryId))]
        public int CategoryId {  get; set; }

        public Category ?category { get; set; } 

        public ICollection<OrderItem> orderitems { get; set; }

        //bura price elave etmelisen 


        private int? _price;

        public int? Price
        {
            get { return _price; }
            set { _price = value; OnPropertyChanged(); }
        }

        

        
        
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    } 
}