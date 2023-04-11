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
    /// Логика взаимодействия для PageCarrier.xaml
    /// </summary>
    public partial class PageCarrier : Page
    {
        CarrierTableAdapter carrier = new CarrierTableAdapter();
        public PageCarrier()
        {
            InitializeComponent();
            CarrierDtGrd.ItemsSource = carrier.GetData();
        }

        private void AddCarrierBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PlaceTxtBx.Text != null)
                {
                    carrier.InsertQuery(PlaceTxtBx.Text);
                    CarrierDtGrd.ItemsSource = carrier.GetData();
                }
            }
            catch { Mistakes.Text = "Что-то не так"; }
        }

        private void UpdateCarrierBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CarrierDtGrd.SelectedItem != null && PlaceTxtBx.Text != null)
                {
                    var sel = (CarrierDtGrd.SelectedItem as DataRowView).Row[0];
                    carrier.UpdateQuery(PlaceTxtBx.Text, (int)sel);
                    CarrierDtGrd.ItemsSource = carrier.GetData();
                }
            }
            catch { Mistakes.Text = "Что-то пошло не так"; }
        }

        private void DeleteCarrierStaffBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CarrierDtGrd.SelectedItem != null)
                {
                    var sel = (CarrierDtGrd.SelectedItem as DataRowView).Row[0];
                    carrier.DeleteQuery((int)sel);
                    CarrierDtGrd.ItemsSource = carrier.GetData();
                }
            }
            catch { Mistakes.Text = "Что-то пошло не так"; }
        }

        private void CarrierDtGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CarrierDtGrd.SelectedItem != null)
            {
                var sel = CarrierDtGrd.SelectedItem as DataRowView;
                PlaceTxtBx.Text = sel.Row[1].ToString();
            }
            else
            {
                PlaceTxtBx.Text = null;
            }
        }

        private void ImportCarrierStaffBtn_Click(object sender, RoutedEventArgs e)
        {
            List<ClassCarriers> forImport = ClassForDS.DeserializeObj<List<ClassCarriers>>();
            foreach (ClassCarriers c in forImport)
            {
                carrier.InsertQuery(c.Place);
            }
            CarrierDtGrd.ItemsSource = null;
            CarrierDtGrd.ItemsSource = carrier.GetData();
        }
    }
}
