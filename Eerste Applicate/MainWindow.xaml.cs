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

namespace Eerste_Applicate
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
        int teller = 0;


        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            lblWorld.Content = "Hello World!!!";
        }

        private void btnHello_Copy_Click(object sender, RoutedEventArgs e)
        {

            teller++;
            lblWorld_Copy.Content = teller.ToString();
        }
    }
}
