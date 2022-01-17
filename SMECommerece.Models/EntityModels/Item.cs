﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMECommerece.Models.EntityModels
{
    public class Item
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime ManufactureDate { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string ImageName { get; set; }

    }
}
