using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public  class Category :INotifyPropertyChanged
    {
        public int Id { get; set; }




        private string? _name;

        public string? Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private int?  _quantity;

        public int?  Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }



        private string ? _description;

        public string ? Description
        {
            get { return _description; }
            set { _description = value; }
        }


        private string? _mediaurl;

        public string? MediaUrl
        {
            get { return _mediaurl; }
            set { _mediaurl = value; }
        }

        

        public ICollection<Product>products { get; set; }

       
        
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public override string ToString()
        {
            return Name; // veya kendi istediğiniz formatı buraya yazabilirsiniz
        }
    }
}
