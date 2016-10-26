using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateLibrary
{
    public class DBConnection
    {
        protected string Name;

        public DBConnection(string name)
        {
            this.name = name;
        }

        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
    }
}
