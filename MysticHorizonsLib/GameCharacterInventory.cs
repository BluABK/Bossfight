using System.Collections.Generic;
using System.Linq;

namespace MysticHorizonsLib
{
    public class GameCharacterInventory
    {
        private readonly List<Item> items;

        public GameCharacterInventory()
        {
            items = new();
        }

        public bool HasItem(Item item)
        {
            return items.Any(existingItem => existingItem.Id == item.Id);
        }

        public bool HasItem(int itemId)
        {
            return items.Any(existingItem => existingItem.Id == itemId);
        }

        public bool HasItem(string itemName)
        {
            return items.Any(existingItem => existingItem.Name == itemName);
        }

        public Item GetItem(int itemId)
        {
            return items.Find(existingItem => existingItem.Id == itemId);
        }

        public Item GetAndUseItem(int itemId)
        {
            Item matchedItem = items.Find(existingItem => existingItem.Id == itemId);
            items.Remove(matchedItem);
            
            return matchedItem;
        }

        public void Add(Item item) 
        {
            if (!HasItem(item))
            {
                items.Add(item);
            } else
            {

            }
        }

        public void Remove(int itemId)
        {
            if (HasItem(itemId))
            {
                items.Remove(GetItem(itemId));
            } else
            {
                throw new KeyNotFoundException($"List of items has no such item with ID: {itemId}!");
            }
        }
    }
}