using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events1App
{
    class InventoryWatcher // Suscritor.
    {
        InventoryManager inventoryManager;

        public InventoryWatcher(InventoryManager inventoryManager)
        {
            this.inventoryManager = inventoryManager;
            inventoryManager.OnInventoryChangeHandler += new 
            InventoryManager.InventoryChangeEventHandler(OnInvetoryChange);
        }

        void OnInvetoryChange(object source, InventoryChangeEventArgs e)
        {
            int change = e.Change;
            Console.WriteLine("Sede '{0}' es {1} en {2} unidades",
                e.Sku,
                change > 0 ? "Incremento" : "Decremento",
                Math.Abs(e.Change));

            Console.ReadLine();
        }

    }
}
