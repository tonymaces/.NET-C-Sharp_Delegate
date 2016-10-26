using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events1App
{
    class InventoryManager //Editor
    {
        public delegate void InventoryChangeEventHandler
          (object source, InventoryChangeEventArgs e);

        public event InventoryChangeEventHandler OnInventoryChangeHandler;
        public void UpdateInventory(String sku, int change)
        {
            if (0 == change)
                return; // No actualizar o cambio a nulo.

            // Codigo para actualizar la base de datos iria aqui.

            InventoryChangeEventArgs e = new
            InventoryChangeEventArgs(sku, change);

            if (OnInventoryChangeHandler != null)
                OnInventoryChangeHandler(this, e);
        }
    }
}
