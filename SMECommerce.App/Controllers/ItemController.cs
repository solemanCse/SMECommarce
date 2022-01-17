using EFCoreExamples.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
 
using SMECommerce.App.Models.ItemModels;
using SMECommerce.Repositories;
using SMECommerce.Services.Abstractions;
using SMECommerece.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerce.App.Controllers
{
    public class ItemController : Controller
    {
        IItemService _itemService;
        ICategoryService _categoryService;
        IBrandService _brandService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ItemController(IItemService itemService, ICategoryService categoryService, IBrandService brandService, IWebHostEnvironment hostEnvironment)
        {
            _itemService = itemService;
            _categoryService = categoryService;
            _brandService = brandService;
           webHostEnvironment = hostEnvironment;
        }
        public IActionResult ItemList()
        {
            ItemListVM vm = new ItemListVM();
            vm.Title = "Item";
            vm.Description = "All Item Informa In Bellow List";
            List<Item> item = _itemService.GetAllItems().ToList();
            vm.itemList = item;
            return View(vm);
        }
        [HttpGet]
        public IActionResult Create()
        {
            
            ItemCreateVM vm = new ItemCreateVM();
            vm.brandList = _brandService.GetAllBrand().ToList();
            vm.categoryList = _categoryService.GetAll().ToList();
            return View(vm);
        }
        [HttpPost]
        public IActionResult Create(ItemCreateVM itemVm)
        {
            var imageName = UploadedFile(itemVm);
            Item aItem = new Item();
            aItem.Code = itemVm.Code;
            aItem.Name = itemVm.Name;
            aItem.Description = itemVm.Description;
            aItem.ManufactureDate = itemVm.ManufactureDate;
            aItem.Price = itemVm.Price;
            aItem.Status = itemVm.Status;
            aItem.CategoryId = itemVm.CategoryId;
            aItem.BrandId = itemVm.BrandId;
            aItem.ImageName = imageName;
            bool result = _itemService.SaveItem(aItem);
            if(result)
            {
                return RedirectToAction("ItemList");
            }
            return View("ItemList");
        }
        private string UploadedFile(ItemCreateVM model)
        {
            string uniqueFileName = null;

            if (model.fileImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Image/Item");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.fileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.fileImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ItemList");
            }
            var itm = _itemService.GetSpecificItemById(id);
            if (itm == null)
            {
                return RedirectToAction("ItemList");
            }

            ItemEditVM vm = new ItemEditVM()
            {
                Id = itm.Id,
                Code = itm.Code,
                Name = itm.Name,
                Description = itm.Description,
                ManufactureDate = itm.ManufactureDate,
                Price = itm.Price,
                CategoryId = itm.CategoryId,
                BrandId = itm.BrandId,
                Status = itm.Status,
                brandList = _brandService.GetAllBrand().ToList(),
                categoryList = _categoryService.GetAll().ToList()
            };
            return View(vm);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ItemList");
            }
            var itm = _itemService.GetSpecificItemById(id);
            if (itm == null)
            {
                return RedirectToAction("CategoryList");
            }
            var result = _itemService.DeleteItem(itm);
            return RedirectToAction("ItemList");
        }
        [HttpPost]
        public IActionResult Edit(ItemEditVM vm)
        {
            if (ModelState.IsValid)
            {
                Item aItm = new Item();
                aItm.Id = vm.Id;
                aItm.Code = vm.Code;
                aItm.Name = vm.Name;
                aItm.Description = vm.Description;
                aItm.CategoryId = vm.CategoryId;
                aItm.BrandId = vm.BrandId;
                aItm.Price = vm.Price;
                aItm.ManufactureDate = vm.ManufactureDate;
                aItm.Status = vm.Status;

                var result = _itemService.UpdateItem(aItm);
                if (result == true)
                {
                    return RedirectToAction("ItemList");
                }
            }
            return RedirectToAction("ItemList");
        }
        public IActionResult Details(int id)
        {
            var item = _itemService.GetSpecificItemById(id);

            var itemVm = new ItemDetailsVM()
            {
                Code = item.Code,
                Name = item.Name,
                Description = item.Description,
                ManufactureDate = item.ManufactureDate,
                Price = item.Price,
                Status = item.Status,
                CategoryId = item.Category.Name,
                BrandId = item.Brand.Name,
                ImageName = item.ImageName
            };
            return View(itemVm);
        }
    }
}
