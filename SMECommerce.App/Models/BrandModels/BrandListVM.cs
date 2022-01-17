using SMECommerece.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerce.App.Models.BrandModels
{
    public class BrandListVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Brand> brandList { get; set; }
    }
}
