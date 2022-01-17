using SMECommerece.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerce.App.Models.ItemModels
{
    public class ItemListVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Item> itemList { get; set; }
         
    }
}
