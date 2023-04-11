using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для PageCity.xaml
    /// </summary>
    public partial class PageCity : Page
    {
        CityTableAdapter city = new CityTableAdapter();
        public PageCity()
        {
            InitializeComponent();
            CityDtGrd.ItemsSource = city.GetData();
        }

        private void AddCityBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CityTxtBx.Text!= null)
                {
                    city.InsertQuery(CityTxtBx.Text);
                    CityDtGrd.ItemsSource = city.GetData();
                }
                else { Mistakes.Text = "Не все поля заполнены"; }
            }
            catch { Mistakes.Text = "Что-то не так"; }
        }

        private void UpdateCityBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CityDtGrd.SelectedItem != null && CityTxtBx.Text !=null)
                {
                    var sel = (CityDtGrd.SelectedItem as DataRowView).Row[0];
                    city.UpdateQuery(CityTxtBx.Text, (int)sel);
                    CityDtGrd.ItemsSource = city.GetData();
                }
            }
            catch { Mistakes.Text = "Что-то не так"; }
        }

        private void DeleteCityBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CityDtGrd.SelectedItem != null)
                {
                    var sel = (CityDtGrd.SelectedItem as DataRowView).Row[0];
                    city.DeleteQuery((int)sel);
                    CityDtGrd.ItemsSource = city.GetData();
                }
            }
            catch { Mistakes.Text = "Что-то не так"; }
        }

        private void CityDtGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CityDtGrd.SelectedItem != null)
            {
                var sel = CityDtGrd.SelectedItem as DataRowView;
                CityTxtBx.Text = sel.Row[1].ToString();
            }
            else
            {
                CityTxtBx.Text = null;
            }
        }

        private void ImportCityBtn_Click(object sender, RoutedEventArgs e)
        {
            List<ClassCities> forImport = ClassForDS.DeserializeObj<List<ClassCities>>();
            foreach (var c in forImport)
            {
                city.InsertQuery(c.Name);
            }
            CityDtGrd.ItemsSource = null;
            CityDtGrd.ItemsSource = city.GetData();
        }
    }
}
