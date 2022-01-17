using SMECommerce.Repositories.Abstractions;
using SMECommerce.Services.Abstractions;
using SMECommerece.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services
{
    public class ItemService:IItemService
    {
        IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public Item GetSpecificItemById(int? id)
        {
            return _itemRepository.GetSpecificItemById(id);
        }
        public ICollection<Item> GetAllItems()
        {
            return _itemRepository.GetAllItems();
        }
        public ICollection<Item> GetAllItemByCategory(int cateId)
        {
            return _itemRepository.GetAllItemByCategory(cateId);
        }
        public ICollection<Item> GetAllItemByBrand(int brandId)
        {
            return _itemRepository.GetAllItemByBrand(brandId);
        }
        public bool SaveItem(Item aItem)
        {
            return _itemRepository.SaveItem(aItem);
        }
        public bool UpdateItem(Item aItem)
        {
            return _itemRepository.UpdateItem(aItem);
        }
        public bool DeleteItem(Item aItem)
        {
            return _itemRepository.DeleteItem(aItem);
        }
        public bool SaveItemList(ICollection<Item> aItemList)
        {
            return _itemRepository.SaveItemList(aItemList);
        }
        public bool UpdateItemList(ICollection<Item> aItemList)
        {
            return _itemRepository.UpdateItemList(aItemList);
        }
        public bool DeleteItemList(ICollection<Item> aItemList)
        {
            return _itemRepository.DeleteItemList(aItemList);
        }
    }
}
