using SoftwareDevelopment1.Views;
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

namespace SoftwareDevelopment1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

		private void AddItemPageButton_Click(object sender, RoutedEventArgs e)
		{
			// Create an instance of the AddItem window
			AddItem addItemWindow = new AddItem();

			// Show the AddItem window
			addItemWindow.Show();
		}
	}
}
