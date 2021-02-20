using System;
using System.Linq;
using System.Collections.Generic;

using WarCroft.Constants;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory
{
    public abstract class Bag : IBag
    {
        private int capacity;
        private int load;

        private readonly List<Item> items;

        public Bag(int capacity)
        {
            this.Capacity = capacity;
            this.items = new List<Item>();
        }

        public int Capacity { get; set; } = 100;

        public int Load => this.Items.Sum(i => i.Weight);

        public IReadOnlyCollection<Item> Items => this.items;

        public void AddItem(Item item)
        {
            if (this.Load + item.Weight >= this.Capacity)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.ExceedMaximumBagCapacity));
            }

            this.items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (this.items.Count == 0)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.EmptyBag));
            }

            if (this.items.Any(i => i.GetType().Name != name))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.ItemNotFoundInBag, name));
            }

            var item = this.items.FirstOrDefault(i => i.GetType().Name == name);
            this.items.Remove(item);

            return item;
        }
    }
}
