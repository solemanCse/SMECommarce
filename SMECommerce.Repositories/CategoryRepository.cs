using Microsoft.EntityFrameworkCore;
using SMECommerce.Database.DbContexts;
using SMECommerce.Repositories.Abstractions;
using SMECommerece.Models.EntityModels;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreExamples.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        SMECommerceDbContext db;
        public CategoryRepository(SMECommerceDbContext db)
        {
           this.db = db;
        }
        public Category GetSpecificCategoryById(int? id)
        {
            return db.Categories.FirstOrDefault(e => e.Id == id);
        }
        public ICollection<Category> GetAll()
        {
            return db.Categories.Include(e => e.Items).ToList();
        }

        public bool Add(Category aCategory)
        {
            db.Categories.Add(aCategory);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }
        public bool Update(Category aCategory)
        {
            db.Categories.Update(aCategory);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }
        public bool Delete(Category aCategory)
        {
            db.Categories.Remove(aCategory);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }

        //public bool SaveCategoryList(ICollection<Category> aCategoryList)
        //{
        //    db.Categories.AddRange(aCategoryList);
        //    int sucess = db.SaveChanges();
        //    return sucess > 0;
        //}
        //public bool UpdateCategoryList(ICollection<Category> aCategoryList)
        //{
        //    db.Categories.UpdateRange(aCategoryList);
        //    int sucess = db.SaveChanges();
        //    return sucess > 0;
        //}
        //public bool DeleteCategoryList(ICollection<Category> aCategoryList)
        //{
        //    db.Categories.RemoveRange(aCategoryList);
        //    int sucess = db.SaveChanges();
        //    return sucess > 0;
        //}
    }
}
