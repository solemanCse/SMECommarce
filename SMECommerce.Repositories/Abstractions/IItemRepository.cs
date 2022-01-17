using SMECommerece.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Repositories.Abstractions
{
    public interface IItemRepository
    {
        Item GetSpecificItemById(int? id);
        ICollection<Item> GetAllItems();
        ICollection<Item> GetAllItemByCategory(int cateId);
        ICollection<Item> GetAllItemByBrand(int brandId);
        bool SaveItem(Item aItem);
        bool UpdateItem(Item aItem);
        bool DeleteItem(Item aItem);
        bool SaveItemList(ICollection<Item> aItemList);
        bool UpdateItemList(ICollection<Item> aItemList);
        bool DeleteItemList(ICollection<Item> aItemList);
    }
}
