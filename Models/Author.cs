using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Author : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string lastname;

        public int Id 
        { 
            get => id; set
            {
                id = value;
                OnPropertyChanged(nameof(Id));  
            }
        }

        public string Name 
        { 
            get => name; set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Lastname
        { 
            get => lastname; set
            {
                lastname = value;
                OnPropertyChanged(nameof(Lastname));
            }
        }

    public ICollection<ItemAuthor> ItemAuthors { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
