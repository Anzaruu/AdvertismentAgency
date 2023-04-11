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
    /// Логика взаимодействия для PagePosition.xaml
    /// </summary>
    public partial class PagePosition : Page
    {
        PositionTableAdapter position = new PositionTableAdapter();
        public PagePosition()
        {
            InitializeComponent();
            PositionDtGrd.ItemsSource = position.GetData();
        }

        private void AddPositionBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RoleTxtBx.Text != null)
                {
                    position.InsertQuery(RoleTxtBx.Text);
                    PositionDtGrd.ItemsSource = position.GetData();
                }
                else { Mistakes.Text = "Поля не заполнены"; }
            }
            catch { Mistakes.Text = "Что-от не так"; }
        }

        private void UpdatePositionBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RoleTxtBx.Text != null && PositionDtGrd.SelectedItem != null)
                {
                    var sel = (PositionDtGrd.SelectedItem as DataRowView).Row[0];
                    position.UpdateQuery(RoleTxtBx.Text, (int)sel);
                    PositionDtGrd.ItemsSource = position.GetData();
                }
                else { Mistakes.Text = "Поля не заполнены"; }
            }
            catch { Mistakes.Text = "Что-от не так"; }
        }

        private void DeletePositionStaffBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PositionDtGrd.SelectedItem != null)
                {
                    var sel = (PositionDtGrd.SelectedItem as DataRowView).Row[0];
                    position.DeleteQuery((int)sel);
                    PositionDtGrd.ItemsSource = position.GetData();
                }
            }
            catch { Mistakes.Text = "Что-от не так"; }
        }

        private void PositionDtGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PositionDtGrd.SelectedItem != null)
            {
                var sel = PositionDtGrd.SelectedItem as DataRowView;
                RoleTxtBx.Text = sel.Row[1].ToString();
            }
            else
            {
                RoleTxtBx.Text = null;
            }

        }
    }
}
