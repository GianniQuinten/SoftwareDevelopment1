using SoftwareDevelopment1.ViewModels;
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
using System.Windows.Shapes;

namespace SoftwareDevelopment1.Views
{
    /// <summary>
    /// Interaction logic for AuthorDetails.xaml
    /// </summary>
    public partial class AuthorDetails : Window
    {

        authorCrudEntities _db = new authorCrudEntities();
        public AuthorDetails()
        {
            InitializeComponent();
            DataContext =  new AuthorViewModel();
        }
    }
}
