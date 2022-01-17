using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMECommerece.Models.EntityModels
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(15)]
        public string Code { get; set; }

        [StringLength(150)]
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public int Status { get; set; }
        public ICollection<Item> Items { get; set; }

    }
}
