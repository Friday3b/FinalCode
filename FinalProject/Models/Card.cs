using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Card : INotifyPropertyChanged
    {

        public int Id { get; set; }

        public int UsersId { get; set; } 

        public string ?Items { get; set; } //string (json) verilib cedvelde 

        public User ?User { get; set; } 
        
        
        public event PropertyChangedEventHandler? PropertyChanged;


        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
