using SMECommerece.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerce.App.Models.ItemModels
{
    public class ItemEditVM
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ManufactureDate { get; set; }
        public double Price { get; set; }
        public int Status { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; } 
        public List<Category> categoryList { get; set; }
        public List<Brand> brandList { get; set; }
    }
}
