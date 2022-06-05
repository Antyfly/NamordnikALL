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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Namordnik.DataBaseNamordnir;
using static Namordnik.DataBaseNamordnir.DataBaseHelper;

namespace Namordnik.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private const int ItemsPerPage = 20;
        public int Page { get; set; } = 0;
        private int _CurrentPageIndex = 0;

        public List<Product> FilterProductList { get; set; }
        public ProductWindow()
        {
            InitializeComponent();
            var productTypeList = GetProductTypes();
            productTypeList.Insert(0, new ProductType { Title = "Все" });
            FilterComboBox.ItemsSource = productTypeList;
            UpdateList();
            GenerateButton();
        }

        public void UpdateList() {
            if (SearchTextBox is null || FilterComboBox is null || SortComboBox is null)
                return;

            var product = GetProducts();

            if (SearchTextBox.Text.Length != 0) {
                product = product.Where(p => p.Title.ToLower().Contains(SearchTextBox.Text.ToLower()) || p.Description?.ToLower().Contains(SearchTextBox.Text.ToLower()) == true).ToList();
            }

            switch (((ComboBoxItem)SortComboBox.SelectedItem).Content.ToString())
            {
                case "Наименование по возрастанию":
                    product = product.OrderBy(p=> p.Title).ToList();
                    break;
                case "Наименование по убыванию":
                    product = product.OrderByDescending(p => p.Title).ToList();
                    break;
                case "Номер производственного цеха по возрастанию":
                    product = product.OrderBy(p => p.ProductionWorkshopNumber).ToList();
                    break;
                case "Номер производственного цеха по убыванию":
                    product = product.OrderByDescending(p => p.ProductionWorkshopNumber).ToList();
                    break;
                case "Минимальная стоимость для агента по возрастанию":
                    product = product.OrderBy(p => p.MinCostForAgent).ToList();
                    break;
                case "Минимальная стоимость для агента по убыванию":
                    product = product.OrderByDescending(p => p.MinCostForAgent).ToList();
                    break;
            }
            if (((ProductType)FilterComboBox.SelectedItem).Title != "Все")
                product = product.Where(p => p.ProductType == (ProductType)FilterComboBox.SelectedItem).ToList();

            ProductListView.ItemsSource = product.Skip(_CurrentPageIndex * 20).Take(20).ToList();

        }
        public void GenerateButton() {
            NumberButtonStackPanel.Children.Clear();
            int pageCount = Convert.ToInt32(Math.Floor((double)GetProducts().Count / ItemsPerPage));
            FilterProductList = GetProducts();

            for (int i = 0; i < pageCount; i++)
            {
                if (ItemsPerPage * i > FilterProductList.Count)
                   continue;

                Button newButton = new Button()
                {
                    Content = i + 1,
                    Background = Brushes.Transparent,
                };
                newButton.Click += NewButton_Click;

                NumberButtonStackPanel.Children.Add(newButton);
            }
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            _CurrentPageIndex = Convert.ToInt32((sender as Button).Content.ToString()) - 1;
            LeftButton.IsEnabled = true;
            UpdateList();
        }
        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            if (_CurrentPageIndex > 0)
            {
                RightButton.IsEnabled = true;
                _CurrentPageIndex--;
                UpdateList();
            }
            else
            {
                LeftButton.IsEnabled = false;
            }
        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
            if (((GetProducts().Count / 20)-1) > _CurrentPageIndex)
            {
                _CurrentPageIndex++;
                LeftButton.IsEnabled = true;
                UpdateList();
            }
            else
            {
                RightButton.IsEnabled = false;
            }
        }

       

        private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateList();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateList();
        }

        private void FilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateList();
        }

        private void NewProductButton_Click(object sender, RoutedEventArgs e)
        {
            NewProductWindow newProduct = new NewProductWindow();
            newProduct.ShowDialog();
            UpdateList();
        }

        private void ChangeMinCostButton_Click(object sender, RoutedEventArgs e)
        {
            new ChangeCostWindow(ProductListView.SelectedItems.Cast<Product>().ToList()).ShowDialog();
            UpdateList();
        }

        private void ProductListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView listView = sender as ListView;
            if (listView.SelectedItems.Count == 0)
            {
                ChangeMinCostButton.Visibility = Visibility.Hidden;
            }
            else
            {
                ChangeMinCostButton.Visibility = Visibility.Visible;
            }
        }
    }
}
