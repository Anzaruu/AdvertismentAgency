using System;
using System.Collections.Generic;
using System.Data;
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
using ProjectAdvert.DataSetTableAdapters;

namespace ProjectAdvert
{
    /// <summary>
    /// Логика взаимодействия для PageService.xaml
    /// </summary>
    public partial class PageService : Page
    {
        ServiceTableAdapter service =new ServiceTableAdapter();
        public PageService()
        {
            InitializeComponent();
            ServiceDtGrd.ItemsSource = service.GetData();
        }

        private void AddServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (KindTxtBx.Text != null)
                {
                    service.InsertQuery(KindTxtBx.Text);
                    ServiceDtGrd.ItemsSource = service.GetData();
                }
                else { Mistkes.Text = "Поле не заполнено"; }
            }
            catch { Mistkes.Text = "Что-то не так"; }
        }

        private void UpdateServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (KindTxtBx.Text != null && ServiceDtGrd.SelectedItem != null)
                {
                    var sel = (ServiceDtGrd.SelectedItem as DataRowView).Row[0];
                    service.UpdateQuery(KindTxtBx.Text, (int)sel);
                    ServiceDtGrd.ItemsSource = service.GetData();
                }
                else { Mistkes.Text = "Поле не заполнено"; }
            }
            catch { Mistkes.Text = "Что-то не так"; }
        }

        private void DeleteServiceStaffBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ServiceDtGrd.SelectedItem != null)
                {
                    var sel = (ServiceDtGrd.SelectedItem as DataRowView).Row[0];
                    service.DeleteQuery((int)sel);
                    ServiceDtGrd.ItemsSource = service.GetData();
                }
            }
            catch { Mistkes.Text = "Что-то не так"; }
        }

        private void ServiceDtGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ServiceDtGrd.SelectedItem != null)
            {
                var sel = ServiceDtGrd.SelectedItem as DataRowView;
                KindTxtBx.Text = sel.Row[1].ToString();
            }
            else
            {
                KindTxtBx.Text = null;
            }
        }
    }
}
