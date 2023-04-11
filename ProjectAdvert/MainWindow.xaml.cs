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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AutorisationTableAdapter autorisationStaff = new AutorisationTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            var prov = autorisationStaff.GetData().Rows;
            for (int i = 0; i < prov.Count; i++)
            {
                if (prov[i][1].ToString() == LoginTxtBx.Text && prov[i][2].ToString() == PasswordTxtBx.Password)
                {
                    int role = (int)prov[i][3];
                    switch (role)
                    {
                        case 1:
                            WindowMainAdmin window = new WindowMainAdmin();
                            window.Show();
                            Close();
                            break;
                        case 2:
                            WindowEmploye window2 = new WindowEmploye();
                            window2.Show();
                            Close();
                            break;
                    }
                    return;
                }
            }
            MessageBox.Show("Неправильный логин или пароль");
        }
    }
}
