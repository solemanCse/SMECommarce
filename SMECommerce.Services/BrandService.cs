using SMECommerce.Repositories.Abstractions;
using SMECommerce.Services.Abstractions;
using SMECommerece.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services
{
    public class BrandService : IBrandService
    {
        IBrandRepository _brandRepository;
        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public Brand GetSpecificBrandById(int? id)
        {
            return _brandRepository.GetSpecificBrandById(id);
        }
        public ICollection<Brand> GetAllBrand()
        {
            return _brandRepository.GetAllBrand();
        }
        public bool SaveBrand(Brand aBrand)
        {
            return _brandRepository.SaveBrand(aBrand);
        }
        public bool UpdateBrand(Brand aBrand)
        {
            return _brandRepository.UpdateBrand(aBrand);
        }

        public bool DeleteBrand(Brand aBrand)
        {
            return _brandRepository.DeleteBrand(aBrand);
        }
        public bool SaveBrandList(ICollection<Brand> aBrandList)
        {
            return _brandRepository.SaveBrandList(aBrandList);
        }

        public bool UpdateBrandList(ICollection<Brand> aBrandList)
        {
            return _brandRepository.UpdateBrandList(aBrandList);
        }
        public bool DeleteBrandList(ICollection<Brand> aBrandList)
        {
            return _brandRepository.DeleteBrandList(aBrandList);
        }
    }
}
