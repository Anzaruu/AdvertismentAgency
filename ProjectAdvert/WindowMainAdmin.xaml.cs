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

namespace ProjectAdvert
{
    /// <summary>
    /// Логика взаимодействия для WindowMainAdmin.xaml
    /// </summary>
    public partial class WindowMainAdmin : Window
    {
        public WindowMainAdmin()
        {
            InitializeComponent();
        }

        private void ToPageStaff_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new PageStaff();
        }

        private void ToPagePosition_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new PagePosition();
        }

        private void ToPageAutoris_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new PageDataAutoris();
        }

        private void ServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new PageService();
        }

        private void CarrierBtn_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new PageCarrier();
        }

        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new PageOrder();
        }
    }
}
