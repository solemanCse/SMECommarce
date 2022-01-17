using EFCoreExamples.Repositories;
using Microsoft.AspNetCore.Mvc;
using SMECommerce.App.Models.CategoryModels;
using SMECommerce.Services;
using SMECommerce.Services.Abstractions;
using SMECommerece.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerce.App.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public string Index()
        {

            //catList.Add(new CategoryCreate() { Code="Cat01",Name="Test Category"});
            return "This is default controller";
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryCreate categoryCreate)
        {

            if (!string.IsNullOrWhiteSpace(categoryCreate.Code))
            {
                Category aCat = new Category();
                aCat.Code = categoryCreate.Code;
                aCat.Name = categoryCreate.Name;
                aCat.Descriptions = categoryCreate.Descriptions;
                aCat.Status = categoryCreate.Status;

                var result = _categoryService.Add(aCat);
                if (result == true)
                {
                    return RedirectToAction("CategoryList");
                }

            }

            return View();
        }
        public IActionResult CategoryList()
        {
            var categoryList = _categoryService.GetAll();
            var categoryListVM = new CategoryListVM()
            {
                Title = "Category Overview",
                Description = "You can View,Add,Update,Delete Category Infomation from here.",
                categoryList = categoryList.ToList()
            };

            //ViewBag.CategoryList = categoryList;//Lossly Type/Weekly Type View Bag Dynamic Type Object View Bag er Under Line Data source hisabe View Data Use hoye Jekono Dhoroner Data View Data Ba View Bag Er Modhe Padhano Jaye bole take Weekly Type Bole
            //ViewData["CategoryList"] = categoryList; // View Data Holo Dynamic Type dICTIONARY
            return View(categoryListVM);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("CategoryList");
            }
            var cate = _categoryService.GetSpecificCategoryById(id);
            if (cate == null)
            {
                return RedirectToAction("CategoryList");
            }

            CategoryEditVM vm = new CategoryEditVM()
            {
                Id = cate.Id,
                Code=cate.Code,
                Name = cate.Name,
                Descriptions = cate.Descriptions,
                Status = cate.Status
            };
            return View(vm);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("CategoryList");
            }
            var cate = _categoryService.GetSpecificCategoryById(id);
            if (cate == null)
            {
                return RedirectToAction("CategoryList");
            }
            var result = _categoryService.Delete(cate); 
            return RedirectToAction("CategoryList"); 
        }
        [HttpPost]
        public IActionResult Edit(CategoryEditVM vm)
        {
            if (ModelState.IsValid)
            {
                Category aCate = new Category();
                aCate.Id = vm.Id;
                aCate.Code = vm.Code;
                aCate.Name = vm.Name;
                aCate.Descriptions = vm.Descriptions;
                aCate.Status = vm.Status;

                var result = _categoryService.Update(aCate);
                if (result == true)
                {
                    return RedirectToAction("CategoryList");
                }
            }
            return RedirectToAction("CategoryList");
        }
        public string CategoryListCreate(CategoryCreate[] categories)
        {
            string data = "Category List Create";
            if (categories.Any())
            {
                foreach (CategoryCreate cat in categories)
                {
                    data += $"Category Create:{cat.Name} Code:{cat.Code} \n\t\t";
                }
            }
            return data;
        }


    }
}
