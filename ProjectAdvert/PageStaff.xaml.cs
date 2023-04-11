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
using Newtonsoft.Json.Linq;
using ProjectAdvert.DataSetTableAdapters;

namespace ProjectAdvert
{
    /// <summary>
    /// Логика взаимодействия для PageStaff.xaml
    /// </summary>
    public partial class PageStaff : Page
    {
        StaffTableAdapter staff = new StaffTableAdapter();
        PositionTableAdapter position = new PositionTableAdapter();
        public PageStaff()
        {
            InitializeComponent();
            StaffDtGrd.ItemsSource = staff.GetData();
            IdPosCmbBx.ItemsSource = position.GetData();
            IdPosCmbBx.DisplayMemberPath = "Role";
            IdPosCmbBx.SelectedValuePath = "Id";

        }

        private void StaffDtGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StaffDtGrd.SelectedItem != null)
            {
                var sel = StaffDtGrd.SelectedItem as DataRowView;
                SurnameTxtBx.Text = sel.Row[1].ToString();
                NameTxtBx.Text = sel.Row[2].ToString();
                LastnameTxtBx.Text = sel.Row[3].ToString();
                SalaryTxtBx.Text = sel.Row[4].ToString();
                IdPosCmbBx.SelectedValue = (int)sel.Row[5];
            }
            else
            {
                SurnameTxtBx.Text = null;
                NameTxtBx.Text = null;
                LastnameTxtBx.Text = null;
                SalaryTxtBx.Text = null;
                IdPosCmbBx.SelectedValue = null;
            }

        }

        private void AddStaffBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value;
                if (SurnameTxtBx.Text != null && NameTxtBx.Text != null && LastnameTxtBx.Text != null && SalaryTxtBx.Text != null && int.TryParse(SalaryTxtBx.Text, out value) == true && IdPosCmbBx.SelectedValue != null)
                {
                    if (Convert.ToInt32(SalaryTxtBx.Text) >= 10000)
                    {
                        staff.InsertQuery(SurnameTxtBx.Text, NameTxtBx.Text, LastnameTxtBx.Text, Convert.ToInt32(SalaryTxtBx.Text), (int)IdPosCmbBx.SelectedValue);
                        StaffDtGrd.ItemsSource = staff.GetData();
                    }
                    else
                    {
                        MistakesTxtBlck.Text = "Укажите нормальную зарплату плиз";
                    }
                }
                else if (NameTxtBx.Text == null || NameTxtBx.Text == null || LastnameTxtBx.Text == null || SalaryTxtBx.Text == null || IdPosCmbBx.SelectedValue == null)
                {
                    MistakesTxtBlck.Text = "Что-то не заполнено";
                }
                else { MistakesTxtBlck.Text = "Проверьте правильность заполнения"; }
            }
            catch { MistakesTxtBlck.Text = "Скорее всего ошибка в типе данных или в быстром нажатии на кнопку"; }
        }

        private void UpdateStaffBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value;
                if (StaffDtGrd.SelectedItem != null && SurnameTxtBx.Text != null && NameTxtBx.Text != null && LastnameTxtBx.Text != null && SalaryTxtBx.Text != null && int.TryParse(SalaryTxtBx.Text, out value) == true && IdPosCmbBx.SelectedValue != null)
                {
                    if (Convert.ToInt32(SalaryTxtBx.Text) >= 10000)
                    {
                        var sel = (StaffDtGrd.SelectedItem as DataRowView).Row[0];
                        staff.UpdateQuery(SurnameTxtBx.Text, NameTxtBx.Text, LastnameTxtBx.Text, Convert.ToInt32(SalaryTxtBx.Text), (int)IdPosCmbBx.SelectedValue, (int)sel);
                        StaffDtGrd.ItemsSource = staff.GetData();
                    }
                    else
                    {
                        MistakesTxtBlck.Text = "Укажите нормальную зарплату плиз";
                    }
                }
                else if (NameTxtBx.Text == null || NameTxtBx.Text == null || LastnameTxtBx.Text == null || SalaryTxtBx.Text == null || IdPosCmbBx.SelectedValue == null)
                {
                    MistakesTxtBlck.Text = "Что-то не заполнено";
                }
                else { MistakesTxtBlck.Text = "Проверьте правильность заполнения"; }
            }
            catch { MistakesTxtBlck.Text = "Скорее всего ошибка в типе данных или в быстром нажатии на кнопку"; }
        }

        private void DeleteStaffBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (StaffDtGrd.SelectedItem != null && (int)(StaffDtGrd.SelectedItem as DataRowView).Row[5] != 1)
                {
                    var sel = (StaffDtGrd.SelectedItem as DataRowView).Row[0];
                    staff.DeleteQuery((int)sel);
                    StaffDtGrd.ItemsSource = staff.GetData();
                }
                else if ((int)(StaffDtGrd.SelectedItem as DataRowView).Row[5] != 1)
                {
                    MistakesTxtBlck.Text = "Такого важного человечка удалять нельзя";
                }
            }
            catch { MistakesTxtBlck.Text = "Скорее всего ошибка в быстром нажатии на кнопку";  }
        }
    }
}
