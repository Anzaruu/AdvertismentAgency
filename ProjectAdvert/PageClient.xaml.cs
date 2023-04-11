using System;
using System.Collections;
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
    /// Логика взаимодействия для PageClient.xaml
    /// </summary>
    public partial class PageClient : Page
    {
        ClientTableAdapter client = new ClientTableAdapter();
        CityTableAdapter city = new CityTableAdapter();
        public PageClient()
        {
            InitializeComponent();
            ClientDtGrd.ItemsSource = client.GetData();
            IdCityCmbBx.ItemsSource = city.GetData();
            IdCityCmbBx.DisplayMemberPath = "Name";
            IdCityCmbBx.SelectedValuePath = "Id";
        }

        private void AddClientBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value;
                if (NameTxtBx.Text != null && SurnameTxtBx.Text!=null && LastnameTxtBx.Text!=null && PaspNumTxtBx.Text.Length > 5 && PaspNumTxtBx.Text.Length < 7 && int.TryParse(PaspNumTxtBx.Text, out value) == true && IdCityCmbBx.SelectedValue != null)
                {
                    client.InsertQuery(SurnameTxtBx.Text, NameTxtBx.Text, LastnameTxtBx.Text, Convert.ToInt32(PaspNumTxtBx.Text), (int)IdCityCmbBx.SelectedValue);
                    ClientDtGrd.ItemsSource = client.GetData();
                }
                else if(PaspNumTxtBx.Text.Length <= 5 || PaspNumTxtBx.Text.Length >= 7 || int.TryParse(PaspNumTxtBx.Text, out value) == false)
                {
                    Mistakes.Text = "Проверьте серию и номер паспорта";
                }
                else
                {
                    Mistakes.Text = "Проверьте заполнение полей";
                }
            }
            catch { Mistakes.Text = "Что-то не так"; }
        }

        private void UpdateClientBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ClientDtGrd.SelectedValue != null)
            {
                try
                {
                    int value;
                    if (NameTxtBx.Text != null && SurnameTxtBx.Text != null && LastnameTxtBx.Text != null && PaspNumTxtBx.Text.Length > 5 && PaspNumTxtBx.Text.Length < 7 && int.TryParse(PaspNumTxtBx.Text, out value) == true && IdCityCmbBx.SelectedValue != null)
                    {
                        var sel = (ClientDtGrd.SelectedItem as DataRowView).Row[0];
                        client.UpdateQuery(SurnameTxtBx.Text, NameTxtBx.Text, LastnameTxtBx.Text, Convert.ToInt32(PaspNumTxtBx.Text), (int)IdCityCmbBx.SelectedValue, (int)sel);
                        ClientDtGrd.ItemsSource = client.GetData();
                    }
                    else if (PaspNumTxtBx.Text.Length <= 5 || PaspNumTxtBx.Text.Length >= 7 || int.TryParse(PaspNumTxtBx.Text, out value) == false)
                    {
                        Mistakes.Text = "Проверьте серию и номер паспорта";
                    }
                    else
                    {
                        Mistakes.Text = "Проверьте заполнение полей";
                    }
                }
                catch { Mistakes.Text = "Что-то не так"; }
            }
        }

        private void DeleteClientBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ClientDtGrd.SelectedItem != null)
            {
                try
                {
                    int value;
                    if (NameTxtBx.Text != null && SurnameTxtBx.Text != null && LastnameTxtBx.Text != null && PaspNumTxtBx.Text.Length > 5 && PaspNumTxtBx.Text.Length < 7 && int.TryParse(PaspNumTxtBx.Text, out value) == true && IdCityCmbBx.SelectedValue != null)
                    {
                        var sel = (ClientDtGrd.SelectedItem as DataRowView).Row[0];
                        client.DeleteQuery((int)sel);
                        ClientDtGrd.ItemsSource = client.GetData();
                    }
                    else if (PaspNumTxtBx.Text.Length <= 5 || PaspNumTxtBx.Text.Length >= 7 || int.TryParse(PaspNumTxtBx.Text, out value) == false)
                    {
                        Mistakes.Text = "Проверьте серию и номер паспорта";
                    }
                    else
                    {
                        Mistakes.Text = "Проверьте заполнение полей";
                    }
                }
                catch { Mistakes.Text = "Что-то не так"; }
            }
        }

        private void ClientDtGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ClientDtGrd.SelectedItem != null)
            {
                var sel = ClientDtGrd.SelectedItem as DataRowView;
                SurnameTxtBx.Text = sel.Row[1].ToString();
                NameTxtBx.Text = sel.Row[2].ToString();
                LastnameTxtBx.Text = sel.Row[3].ToString();
                PaspNumTxtBx.Text = sel.Row[4].ToString();
                IdCityCmbBx.SelectedValue = (int)sel.Row[5];
            }
            else
            {
                SurnameTxtBx.Text = null;
                NameTxtBx.Text = null;
                LastnameTxtBx.Text = null;
                PaspNumTxtBx.Text = null;
                IdCityCmbBx.SelectedValue = null;
            }
        }
    }
}
