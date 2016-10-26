using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DelegateLibrary;

namespace Delegate1App
{
    class Delegate1App
    {
        public static void ActiveConnetionsCallback(DBConnection connection)
        {
            Console.WriteLine("Invocando metodo de devolucion de llamada para"
                                + connection.name);

            Console.ReadLine();
        }

        public static void Main()
        {
            DBManager dbMgr = new DBManager();
            dbMgr.AddConnections();

            DBManager.EnumConnectionsCallback myCallback =
                new DBManager.EnumConnectionsCallback(ActiveConnetionsCallback);
            DBManager.EnumConnections(myCallback);
           
        }
    }
}
