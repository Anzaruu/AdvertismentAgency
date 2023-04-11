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
    /// Логика взаимодействия для WindowEmploye.xaml
    /// </summary>
    public partial class WindowEmploye : Window
    {
        public WindowEmploye()
        {
            InitializeComponent();
        }

        private void ToPageCityBtn_Click(object sender, RoutedEventArgs e)
        {
            PageMoving.Content = new PageCity();
        }

        private void ToPageClientBtn_Click(object sender, RoutedEventArgs e)
        {
            PageMoving.Content = new PageClient();
        }

        private void ToPageChequeBtn_Click(object sender, RoutedEventArgs e)
        {
            PageMoving.Content = new PageCheque();
        }

        private void ToPageSavedChequeBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
