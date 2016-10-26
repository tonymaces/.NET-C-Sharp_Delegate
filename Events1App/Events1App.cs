using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events1App
{
    class Events1App
    {
        public static void Main()
        {
            InventoryManager inventoryManager =
                new InventoryManager();

            InventoryWatcher inventoryWatch =
                new InventoryWatcher(inventoryManager);

            inventoryManager.UpdateInventory("111 006 116", -2);
            inventoryManager.UpdateInventory("111 005 303", 5);
        }
    }
}
