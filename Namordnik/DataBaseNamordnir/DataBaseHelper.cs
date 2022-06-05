using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namordnik.DataBaseNamordnir
{
    public static class DataBaseHelper
    {
        private static NamordnikEntities _Entities = new NamordnikEntities();

        public static List<Product> GetProducts()
        {
            return _Entities.Product.ToList();
        }

        public static List<Material> GetMaterials()
        {
            return _Entities.Material.ToList();
        }

        public static List<ProductType> GetProductTypes()
        {
            return _Entities.ProductType.ToList();
        }

        public static void SaveChange()
        {
            _Entities.SaveChanges();
        }

        public static void AddNewProduct(Product newProduct)
        {
            _Entities.Product.Add(newProduct);
             _Entities.SaveChanges();
        }

    }
}
