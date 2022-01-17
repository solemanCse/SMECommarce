using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerce.App.Models.CategoryModels
{
    public class CategoryEditVM
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string Descriptions { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
