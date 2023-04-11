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
    /// Логика взаимодействия для PageOrder.xaml
    /// </summary>
    public partial class PageOrder : Page
    {
        OrderTableAdapter order = new OrderTableAdapter();
        ServiceTableAdapter service = new ServiceTableAdapter();
        CarrierTableAdapter carrier = new CarrierTableAdapter();
        public PageOrder()
        {
            InitializeComponent();
            OrderDtGrd.ItemsSource = order.GetDataBy3();

            IdCarrierCmbBx.ItemsSource = carrier.GetData();
            IdCarrierCmbBx.DisplayMemberPath = "Place";
            IdCarrierCmbBx.SelectedValuePath = "Id";

            IdServiceCmbBx.ItemsSource = service.GetData();
            IdServiceCmbBx.DisplayMemberPath = "Kind";
            IdServiceCmbBx.SelectedValuePath = "Id";
        }

        private void AddOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value;
                if (IdCarrierCmbBx.SelectedValue != null && IdServiceCmbBx.SelectedValue != null && PriceTxtBx.Text != null && int.TryParse(PriceTxtBx.Text, out value) == true)
                {
                    if (Convert.ToInt32(PriceTxtBx.Text) > 1000)
                    {
                        order.InsertQuery((int)IdCarrierCmbBx.SelectedValue, (int)IdServiceCmbBx.SelectedValue, Convert.ToInt32(PriceTxtBx.Text));
                        OrderDtGrd.ItemsSource = order.GetDataBy3();
                    }
                    else { Mistakes.Text = "Чиcло побольше плиз"; }
                }
                else { Mistakes.Text = "Либо поля не заполнены, либо не тот тип данных в цене"; }
            }
            catch { Mistakes.Text = "Что-то не так"; }
        }

        private void UpdateOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value;
                if (OrderDtGrd.SelectedItem != null && IdCarrierCmbBx.SelectedValue != null && IdServiceCmbBx.SelectedValue != null && PriceTxtBx.Text != null && int.TryParse(PriceTxtBx.Text, out value) == true)
                {
                    if (Convert.ToInt32(PriceTxtBx.Text) > 1000)
                    {
                        var sel = (OrderDtGrd.SelectedItem as DataRowView).Row[0];
                        order.UpdateQuery((int)IdCarrierCmbBx.SelectedValue, Convert.ToInt32(PriceTxtBx.Text), (int)IdServiceCmbBx.SelectedValue, (int)sel);
                        OrderDtGrd.ItemsSource = order.GetDataBy3();
                    }
                    else { Mistakes.Text = "Чиcло побольше плиз"; }
                }
                else { Mistakes.Text = "Либо поля не заполнены, либо не тот тип данных в цене"; }
            }
            catch { Mistakes.Text = "Что-то не так"; }
        }

        private void DeleteOrderStaffBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OrderDtGrd.SelectedItem != null)
                {
                    var sel = (OrderDtGrd.SelectedItem as DataRowView).Row[0];
                    order.DeleteQuery((int)sel);
                    OrderDtGrd.ItemsSource = order.GetDataBy3();
                }
            }
            catch { Mistakes.Text = "Что-то не так"; }
        }

        private void OrderDtGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderDtGrd.SelectedItem != null)
            {
                var sel = OrderDtGrd.SelectedItem as DataRowView;
                IdCarrierCmbBx.SelectedValue = (int)sel.Row[1];
                IdServiceCmbBx.SelectedValue = (int)sel.Row[2];
            }
            else
            {
                IdCarrierCmbBx.SelectedValue = null;
                IdServiceCmbBx.SelectedValue = null;
            }
        }
    }
}
