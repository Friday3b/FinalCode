using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Order :INotifyPropertyChanged
    {
        //bu Composite Primary Key olaraq gedecek ve bunu data annotations lar ile gostermek lazimdir systemde

        public int Id { get; set; } 

        public string ?Address { get; set; }  
        


        public DateTime ?Date { get; set; }     

        public int UsersId { get; set; } 

        public int ?Quantity { get; set; } 


        public List<OrderItem> OrderItems { get; set; }

        
        
        public event PropertyChangedEventHandler? PropertyChanged;


        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
