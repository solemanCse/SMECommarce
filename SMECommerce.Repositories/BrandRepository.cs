using Microsoft.EntityFrameworkCore;
using SMECommerce.Database.DbContexts;
using SMECommerce.Repositories.Abstractions;
using SMECommerece.Models.EntityModels;
using System.Collections.Generic;
using System.Linq;

namespace SMECommerce.Repositories
{
    public class BrandRepository: IBrandRepository
    {
        SMECommerceDbContext db;
        public BrandRepository(SMECommerceDbContext db)
        {
            this.db = db;
        }

        public Brand GetSpecificBrandById(int? id)
        {
            return db.Brands.FirstOrDefault(e => e.Id == id);
        }
        public ICollection<Brand> GetAllBrand()
        {
            return db.Brands.Include(e => e.Items).ToList();
        }

        public bool SaveBrand(Brand aBrand)
        {
            db.Brands.Add(aBrand);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }
        public bool UpdateBrand(Brand aBrand)
        {
            db.Brands.Update(aBrand);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }
        public bool DeleteBrand(Brand aBrand)
        {
            db.Brands.Remove(aBrand);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }

        public bool SaveBrandList(ICollection<Brand> aBrandList)
        {
            db.Brands.AddRange(aBrandList);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }
        public bool UpdateBrandList(ICollection<Brand> aBrandList)
        {
            db.Brands.UpdateRange(aBrandList);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }
        public bool DeleteBrandList(ICollection<Brand> aBrandList)
        {
            db.Brands.RemoveRange(aBrandList);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }
    }
}
