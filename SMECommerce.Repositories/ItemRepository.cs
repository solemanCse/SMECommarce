using Microsoft.EntityFrameworkCore;
using SMECommerce.Database.DbContexts;
using SMECommerce.Repositories.Abstractions;
using SMECommerece.Models.EntityModels;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreExamples.Repositories
{
    public class ItemRepository: IItemRepository
    {
        SMECommerceDbContext db;
        public ItemRepository(SMECommerceDbContext db)
        {
            this.db = db;
        }
        public Item GetSpecificItemById(int? id)
        {
            return db.Items.Include(c=>c.Category)
                           .Include(b=>b.Brand)
                           .FirstOrDefault(e => e.Id == id);
        }
        public ICollection<Item> GetAllItems()
        {
            return db.Items.Include(c => c.Category)
                           .Include(b => b.Brand).ToList();
        }
        public ICollection<Item> GetAllItemByCategory(int cateId)
        {
            return db.Items.Include(c => c.Category)
                          .Include(b => b.Brand).Where(e=>e.CategoryId== cateId).ToList();
        }
        public ICollection<Item> GetAllItemByBrand(int brandId)
        {
            return db.Items.Include(c => c.Category)
                          .Include(b => b.Brand).Where(e => e.BrandId == brandId).ToList();
        }
        public bool SaveItem(Item aItem)
        {
            db.Items.Add(aItem);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }
        public bool UpdateItem(Item aItem)
        {
            db.Items.Update(aItem);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }
        public bool DeleteItem(Item aItem)
        {
            db.Items.Remove(aItem);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }

        public bool SaveItemList(ICollection<Item> aItemList)
        {
            db.Items.AddRange(aItemList);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }
        public bool UpdateItemList(ICollection<Item> aItemList)
        {
            db.Items.UpdateRange(aItemList);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }
        public bool DeleteItemList(ICollection<Item> aItemList)
        {
            db.Items.RemoveRange(aItemList);
            int sucess = db.SaveChanges();
            return sucess > 0;
        }
    }
}
