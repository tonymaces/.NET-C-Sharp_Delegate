using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events1App
{
    class InventoryChangeEventArgs : EventArgs
    {
        string sku;
        int change;
        public InventoryChangeEventArgs(string sku, int change)
        {
            this.sku = sku;
            this.change = change;

        }
        public string Sku
        {
            get { return sku; }
        }

        public int Change
        {
            get { return change; }
        }

    }
}
