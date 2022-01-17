using SMECommerece.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services.Abstractions
{
   public interface ICategoryService
    {
        ICollection<Category> GetAll();
        Category GetSpecificCategoryById(int? id);
        bool Add(Category category);
        bool Update(Category category);
        bool Delete(Category category);
    }
}
