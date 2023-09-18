using SoftwareDevelopment1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopment1.ViewModels
{
    public class AuthorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<AuthorDetails>  _lstAuthorDetails;

        public ObservableCollection<AuthorDetails> LstAuthorDetails
        {
            get { return _lstAuthorDetails; }
            set
            {
                _lstAuthorDetails = value;
                OnPropertyChanged(nameof(LstAuthorDetails));
            }
        }
        
        AuthorE
        public AuthorViewModel()
        {

        }
    }
}
