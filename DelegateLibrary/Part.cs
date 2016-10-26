using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateLibrary
{
    public class Part
    {
        protected string Sku;
        protected int Onhand;

        public Part(string sku)
        { 
            
        }
        public string sku
        {
            get { return this.Sku; }
            set { this.Sku = value; }
        }

        public int onhand
        {
            get { return this.Onhand; }
            set { this.Onhand = value; }
        }


    }
}
