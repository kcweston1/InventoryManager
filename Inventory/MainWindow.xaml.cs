using Inventory.ViewModels;
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

namespace Inventory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.DataContext = new InventoryViewModel();
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("you clicked");
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("mouse up");
        }
    }
}
