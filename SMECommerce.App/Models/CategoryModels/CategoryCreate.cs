using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerce.App.Models.CategoryModels
{
    public class CategoryCreate
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public int Status { get; set; }
    }
}
