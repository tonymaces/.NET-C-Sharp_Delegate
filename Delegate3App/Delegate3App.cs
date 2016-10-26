using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DelegateLibrary;


namespace Delegate3App
{
    class Delegate3App
    {
       
        public DBManager.EnumConnectionsCallback myCallback
        {
            get
            {
                return new DBManager.EnumConnectionsCallback(ActiveConnetionsCallback);
            }
        }

        public static void ActiveConnetionsCallback(DBConnection connection)
        {
            Console.WriteLine("Invocando metodo de devolucion de llamada para"
                                + connection.name);

            Console.ReadLine();
        }
        public static void Main()
        {
            Delegate3App app = new Delegate3App();
            DBManager dbMgr = new DBManager();
            dbMgr.AddConnections();
            DBManager.EnumConnections(app.myCallback);

        }
    }
}
