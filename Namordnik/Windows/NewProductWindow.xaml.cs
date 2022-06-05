using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Namordnik.DataBaseNamordnir;
using static Namordnik.DataBaseNamordnir.DataBaseHelper;

namespace Namordnik.Windows
{
    /// <summary>
    /// Логика взаимодействия для NewProductWindow.xaml
    /// </summary>
    public partial class NewProductWindow : Window
    {
        private string ProductImage;
        public NewProductWindow()
        {
            InitializeComponent();
            ProductTypeComboBox.ItemsSource = GetProductTypes();
        }

        
        private void AddNewProductButton_Click(object sender, RoutedEventArgs e)
        {
            if (TitleTextBox.Text.Length == 0 )  
               MessageBox.Show("Наименнование продукта не введено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            
            if (ArticleNumberTextBox.Text.Length == 0)
                MessageBox.Show("Артикул продукта не введен", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            if (ProductionPersonCountTextBox.Text.Length == 0 )
                MessageBox.Show("Количество человек для производства не введено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            if (ProductionWorkshopNumberTextBox.Text.Length == 0)
                MessageBox.Show("Номер производственного цеха не введен", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            AddProduct();
        }


        private void AddProduct()
        {
            Product NewProduct = FillProduct(new Product());

            AddNewProduct(NewProduct);
            MessageBox.Show("Продукт успешно добавлен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
        private Product FillProduct(Product product)
        {
            product.Title = TitleTextBox.Text;
            product.ProductTypeID = ProductTypeComboBox.SelectedIndex + 1;
            product.ArticleNumber = ArticleNumberTextBox.Text;
            product.Description = DescriptionTextBox.Text;
            product.Image = ProductImage;
            product.ProductionPersonCount = Convert.ToInt32(ProductionPersonCountTextBox.Text);
            product.ProductionWorkshopNumber = Convert.ToInt32(ProductionWorkshopNumberTextBox.Text);
            product.MinCostForAgent = Convert.ToDecimal(MinCostForAgentTextBox.Text.Replace('.', ','));
            return product;
        }
        private void AddImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image (*.png);(*.jpg);(*.jpeg) | *.png;*.jpg;*.jpeg;";


            if (fileDialog.ShowDialog() == true)
            {
                string path = fileDialog.FileName;

                File.Copy(path, Directory.GetCurrentDirectory() + $@"\products\{System.IO.Path.GetFileName(path)}", true);

                ProductImage = $@"\products\" + System.IO.Path.GetFileName(path);
            }
        }
    }
}
