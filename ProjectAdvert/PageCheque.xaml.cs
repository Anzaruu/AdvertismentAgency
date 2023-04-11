using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using Microsoft.Win32;
using ProjectAdvert.DataSetTableAdapters;

namespace ProjectAdvert
{
    /// <summary>
    /// Логика взаимодействия для PageCheque.xaml
    /// </summary>
    public partial class PageCheque : Page
    {
        OrderTableAdapter order = new OrderTableAdapter();
        StaffTableAdapter scaff = new StaffTableAdapter();
        ClientTableAdapter client = new ClientTableAdapter();
        List<int> items = new List<int>();

        ChequeInfoTableAdapter chequeInfo = new ChequeInfoTableAdapter();
        ChequeTableAdapter cheque = new ChequeTableAdapter();
        int sum;
        public PageCheque()
        {
            InitializeComponent();
            OrderDtGrd.ItemsSource = order.GetDataBy3();
            StaffCmbBx.ItemsSource = scaff.GetData();
            StaffCmbBx.DisplayMemberPath = "Name";
            StaffCmbBx.SelectedValuePath = "Id";
            ClientCmbBx.ItemsSource = client.GetData();
            ClientCmbBx.DisplayMemberPath = "Name";
            ClientCmbBx.SelectedValuePath = "Id";

        }

        private void PlusInChequeBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OrderDtGrd.SelectedValue != null)
                {
                    CheckDtGrd.Items.Clear();
                    var row = (OrderDtGrd.SelectedValue as DataRowView).Row[0];
                    items.Add((int)row);
                    sum += Convert.ToInt32(order.GetDataBy4((int)row).Rows[0][3]);
                    foreach (var item in items)
                    {
                        CheckDtGrd.Items.Add(order.GetDataBy4(item).Rows[0]);
                    }
                }
            }
            catch { MessageBox.Show("Что-то пошло не так"); }
        }

        private void MinusInChequeBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CheckDtGrd.SelectedValue != null)
                {
                    var row = CheckDtGrd.SelectedValue as DataRow;
                    items.Remove((int)row[0]);
                    sum -= Convert.ToInt32(order.GetDataBy4((int)row[0]).Rows[0][3]);
                    CheckDtGrd.Items.Clear();
                    foreach (var item in items)
                    {
                        CheckDtGrd.Items.Add(order.GetDataBy4(item).Rows[0]);
                    }
                }
            }
            catch { MessageBox.Show("Что-то пошло не так"); }
        }

        private void OrderDtGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderDtGrd.SelectedItem != null)
            {
                var sel = OrderDtGrd.SelectedItem as DataRowView;
            }
        }

        private void CheckDtGrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CheckDtGrd.SelectedItem != null)
            {
                var sel = CheckDtGrd.SelectedItem as DataRowView;
            }
        }

        private void EndingCheque_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value;
                if (ItogSumTxtBx.Text != null && StaffCmbBx.SelectedValue != null && ClientCmbBx.SelectedValue != null && int.TryParse(ItogSumTxtBx.Text, out value) ==true)
                {
                    if (Convert.ToInt32(ItogSumTxtBx.Text) >= sum)
                    {
                        chequeInfo.InsertQuery(DateTime.Now.ToString(), Convert.ToInt32(ItogSumTxtBx.Text), (int)StaffCmbBx.SelectedValue, (int)ClientCmbBx.SelectedValue);
                        var id = chequeInfo.GetDataBy1(DateTime.Now.ToString(), Convert.ToInt32(ItogSumTxtBx.Text), (int)StaffCmbBx.SelectedValue, (int)ClientCmbBx.SelectedValue).Rows[0][0];
                        var builder = new StringBuilder();
                        builder.AppendLine($"{"".PadRight(10, ' ')}ProgectAdvert");
                        builder.AppendLine($"{"".PadRight(10, ' ')}Кассовый чек №" + id.ToString());
                        foreach (var item in items)
                        {
                            builder.AppendLine($"{"".PadRight(7, ' ')}" + order.GetDataBy4(item).Rows[0][4].ToString() + " " + order.GetDataBy4(item).Rows[0][5].ToString() + "--" + order.GetDataBy4(item).Rows[0][3].ToString());
                            cheque.InsertQuery((int)id, item);
                        }
                        builder.AppendLine($"{"".PadRight(5, ' ')}Итого к оплате: " + sum.ToString());
                        builder.AppendLine($"{"".PadRight(5, ' ')}Внесено: " + ItogSumTxtBx.Text.ToString());
                        builder.AppendLine($"{"".PadRight(5, ' ')}Сдача: " + (Convert.ToInt32(ItogSumTxtBx.Text) - sum).ToString());
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        string FilePath;
                        if (saveFileDialog.ShowDialog() == true)
                        {
                            FilePath = saveFileDialog.FileName + ".txt";
                            StreamWriter streamWriter = new StreamWriter(File.Create(FilePath));
                            streamWriter.Write(builder.ToString());
                            streamWriter.Close();
                            CheckDtGrd.Items.Clear();
                            items.Clear();
                            sum = 0;
                            ItogSumTxtBx.Text = null;
                            StaffCmbBx.Text = null;
                            ClientCmbBx.Text = null;
                        }
                    }
                    else
                    {
                        Mistakes.Text = "Что-то введено не так, попробуйте снова";
                    }
                }
            }
            catch (Exception ex)
            {
                Mistakes.Text = "Что-то введено не так, попробуйте снова";
            }
        }
    }
}
