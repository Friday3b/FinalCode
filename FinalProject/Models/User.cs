using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FinalProject.Models
{
    public class User :INotifyPropertyChanged
    {
        public int Id { get; set; } 
        

        private string? _name;
        public string ?Name { get { return _name; }  set { _name= value ; OnPropertyChanged(); } }


        private string? _surname;
        public string? Surname { get { return _surname; } set { _surname = value; OnPropertyChanged(); } }

        private DateTime? _dateOfBirth; //burada DateTime arashdirki duz vermisen ya yox
        public DateTime? DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                if (_dateOfBirth != value)
                {
                    _dateOfBirth = value; OnPropertyChanged();
                }
            }
        }


        private string? _gender;
        public  string? Gender
        {
            get { return _gender; }

            set { _gender = value;OnPropertyChanged(); }
        }


        private string ?_email;
        public string ?Email { get { return _email; } set {_email= value ; OnPropertyChanged(); } }

        private string? _mediaUrl;
        public string? MediaUrl { get { return _mediaUrl; } set { _mediaUrl = value; OnPropertyChanged(); } }


        private string? _password;
        public string? Password { get { return _password; } set { _password = value; OnPropertyChanged(); } }


       

        public int ? CardsId { get; set; } 

        public ICollection <Order > ?Orders { get; set; } 

        public ICollection<Card>?CreditCards { get; set; }

       
        
        public event PropertyChangedEventHandler? PropertyChanged;


        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        
    }
}