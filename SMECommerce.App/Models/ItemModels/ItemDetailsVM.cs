using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerce.App.Models.ItemModels
{
    public class ItemDetailsVM
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ManufactureDate { get; set; }
        public double Price { get; set; }
        public int Status { get; set; }
        public string CategoryId { get; set; }
        public string BrandId { get; set; }
        public string ImageName { get; set; }
    }
}
