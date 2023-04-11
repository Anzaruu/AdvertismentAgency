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
    /// Логика взаимодействия для PageDataAutoris.xaml
    /// </summary>
    public partial class PageDataAutoris : Page
    {
        AutorisationTableAdapter autoris = new AutorisationTableAdapter();
        PositionTableAdapter position = new PositionTableAdapter();
        public PageDataAutoris()
        {
            InitializeComponent();
            AutoDtGrd.ItemsSource = autoris.GetData();
            IdPosCmbBx.ItemsSource = position.GetData();
            IdPosCmbBx.DisplayMemberPath = "Role";
            IdPosCmbBx.SelectedValuePath = "Id";
        }
        private void AutoDtGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AutoDtGrd.SelectedItem != null)
            {
                var sel = AutoDtGrd.SelectedItem as DataRowView;
                LoginTxtBx.Text = sel.Row[1].ToString();
                PasswordTxtBx.Text = sel.Row[2].ToString();
                IdPosCmbBx.SelectedValue = (int)sel.Row[3];
            }
            else
            {
                LoginTxtBx.Text = null;
                PasswordTxtBx.Text = null;
                IdPosCmbBx.SelectedValue = null;
            }
        }

        private void AddAutorBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LoginTxtBx.Text!= null && PasswordTxtBx.Text!=null && IdPosCmbBx.SelectedValue != null)
                {
                    autoris.InsertQuery(LoginTxtBx.Text, PasswordTxtBx.Text, (int)IdPosCmbBx.SelectedValue);
                    AutoDtGrd.ItemsSource = position.GetData();
                }
                else { Mistakes.Text = "Поля не заполнены"; }
            }
            catch { Mistakes.Text = "Что-то не так"; }
        }

        private void UpdateAutorBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AutoDtGrd.SelectedItem != null && LoginTxtBx.Text != null && PasswordTxtBx.Text != null && IdPosCmbBx.SelectedValue != null)
                {
                    var sel = (AutoDtGrd.SelectedItem as DataRowView).Row[0];
                    autoris.UpdateQuery(LoginTxtBx.Text, PasswordTxtBx.Text, (int)IdPosCmbBx.SelectedValue, (int)sel);
                    AutoDtGrd.ItemsSource = autoris.GetData();
                }
                else { Mistakes.Text = "Поля не заполнены"; }
            }
            catch { Mistakes.Text = "Что-то не так"; }
        }

        private void DeleteAutorStaffBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AutoDtGrd.SelectedItem != null)
                {
                    var sel = (AutoDtGrd.SelectedItem as DataRowView).Row[0];
                    autoris.DeleteQuery((int)sel);
                    AutoDtGrd.ItemsSource = autoris.GetData();
                }
            }
            catch { Mistakes.Text = "Что-то не так"; }
        }

    }
}
