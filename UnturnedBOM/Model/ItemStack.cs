using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnturnedBOM.Model
{
    public class ItemStack
    {
        public Item StackedItem { get; set; }
        public int Count { get; set; }

        public ItemStack(Item item, int stackSize)
        {
            
        }
    }
}
