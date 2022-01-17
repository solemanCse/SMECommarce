using SMECommerece.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Repositories.Abstractions
{
    public interface IBrandRepository
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
