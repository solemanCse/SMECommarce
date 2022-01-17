using Microsoft.AspNetCore.Mvc;
using SMECommerce.App.Models.BrandModels;
using SMECommerce.Repositories;
using SMECommerce.Services.Abstractions;
using SMECommerece.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerce.App.Controllers
{
    public class BrandController : Controller
    {
        IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult BrandList()
        {
            BrandListVM vm = new BrandListVM();
            vm.Title = "Brand List";
            vm.Description = "All Brand Information Bellow List";
            vm.brandList = _brandService.GetAllBrand().ToList();
            return View(vm);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(BrandCreate brandCreate)
        {

            if (!string.IsNullOrWhiteSpace(brandCreate.Code))
            {
                Brand aBrnd = new Brand();
                aBrnd.Code = brandCreate.Code;
                aBrnd.Name = brandCreate.Name;
                aBrnd.Description = brandCreate.Description;
                aBrnd.Status = brandCreate.Status;

                var result = _brandService.SaveBrand(aBrnd);
                if (result == true)
                {
                    return RedirectToAction("BrandList");
                }

            }

            return RedirectToAction("BrandList");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("BrandList");
            }
            var brnd = _brandService.GetSpecificBrandById(id);
            if (brnd == null)
            {
                return RedirectToAction("BrandList");
            }

            BrandEditVM vm = new BrandEditVM()
            {
                Id = brnd.Id,
                Code = brnd.Code,
                Name = brnd.Name,
                Description = brnd.Description,
                Status = brnd.Status
            };
            return View(vm);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("BrandList");
            }
            var brnd = _brandService.GetSpecificBrandById(id);
            if (brnd == null)
            {
                return RedirectToAction("BrandList");
            }
            var result = _brandService.DeleteBrand(brnd);
            return RedirectToAction("BrandList");
        }
        [HttpPost]
        public IActionResult Edit(BrandEditVM vm)
        {
            if (ModelState.IsValid)
            {
                Brand aBrand = new Brand();
                aBrand.Id = vm.Id;
                aBrand.Code = vm.Code;
                aBrand.Name = vm.Name;
                aBrand.Description = vm.Description;
                aBrand.Status = vm.Status;

                var result = _brandService.UpdateBrand(aBrand);
                if (result == true)
                {
                    return RedirectToAction("BrandList");
                }
            }
            return RedirectToAction("BrandList");
        }

    }
}
