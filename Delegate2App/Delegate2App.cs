using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DelegateLibrary;

namespace Delegate2App
{
    class Delegate2App
    {
        public static DBManager.EnumConnectionsCallback myCallback =
                new DBManager.EnumConnectionsCallback(ActiveConnetionsCallback);

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
            DBManager.EnumConnections(myCallback);

        }
    }
}
