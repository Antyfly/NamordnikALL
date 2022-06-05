using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Namordnik.DataBaseNamordnir;
using static Namordnik.DataBaseNamordnir.DataBaseHelper;

namespace Namordnik.Windows
{
    /// <summary>
    /// Логика взаимодействия для ChangeCostWindow.xaml
    /// </summary>
    public partial class ChangeCostWindow : Window
    {
        private List<Product> _ProductList;
        public ChangeCostWindow(List<Product> products)
        {
            InitializeComponent();
            _ProductList = products;
            NewCostTextBox.Text = _ProductList.Max(m => m.Cost).ToString();
        }

        private void ChangeSaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (NewCostTextBox.Text.Length == 0)
            {
                MessageBox.Show("Необходимо ввести значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var newCost = NewCostTextBox.Text;
            int intNewCost = 0;

            try
            {
                intNewCost = Convert.ToInt32(newCost);
            }
            catch (Exception)
            {
                MessageBox.Show("Значение должно быть целым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (intNewCost <0 )
            {
                MessageBox.Show("Значение должно быть положительным", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            foreach ( var product in _ProductList)
            {
                product.MinCostForAgent = Convert.ToInt32(NewCostTextBox.Text);
                SaveChange();
            }
            MessageBox.Show("Цена изменена",
                   "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}
