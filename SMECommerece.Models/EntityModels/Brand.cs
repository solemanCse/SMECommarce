using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SMECommerece.Models.EntityModels
{
    public class Brand
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public ICollection<Item> Items { get; set; }

    }
}
