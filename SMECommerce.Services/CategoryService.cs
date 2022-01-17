using EFCoreExamples.Repositories;
using SMECommerce.Repositories.Abstractions;
using SMECommerce.Services.Abstractions;
using SMECommerece.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services
{
    public class CategoryService: ICategoryService
    {
        ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public ICollection<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }
        public bool Add(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.Name))
            {
                return false;
            }
            return _categoryRepository.Add(category);
        }
        public bool Update(Category category)
        { 
            return _categoryRepository.Update(category);
        }

        public bool Delete(Category category)
        {
            return _categoryRepository.Delete(category);
        }

        public Category GetSpecificCategoryById(int? id)
        {
            return _categoryRepository.GetSpecificCategoryById(id);
        }
    }
}
