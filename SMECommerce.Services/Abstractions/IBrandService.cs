using SMECommerece.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services.Abstractions
{
    public interface IBrandService
    {
        Brand GetSpecificBrandById(int? id);
        ICollection<Brand> GetAllBrand();
        bool SaveBrand(Brand aBrand);
        bool UpdateBrand(Brand aBrand);
        bool DeleteBrand(Brand aBrand);
        bool SaveBrandList(ICollection<Brand> aBrandList);
        bool UpdateBrandList(ICollection<Brand> aBrandList);
        bool DeleteBrandList(ICollection<Brand> aBrandList);
    }
}
