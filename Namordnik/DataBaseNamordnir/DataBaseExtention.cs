using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Namordnik.DataBaseNamordnir
{
    public partial class Product
    {
        public string ImageProduct
        {
            get
            {
                var image = Image;
                if (image is null)
                {
                    return "/Image/picture.png";
                }
                else
                {
                    var ImageProduct = Directory.GetCurrentDirectory() + Image.ToString();
                    return ImageProduct;
                        
                }
            }
        }

        public string Material
        {
            get
            {
                var titles = string.Join(",", ProductMaterial.Select(pm => pm.Material.Title).ToList());
                if (titles.Length == 0)
                {
                    return "Нет материалов";
                }
                else
                { 
                    return titles;
                }
            }
        }

        public decimal Cost
        {
            get
            {
                var cost = ProductMaterial.Select(pm => pm.Material.Cost).Sum();
                return cost;
            }
        }
    }
}
