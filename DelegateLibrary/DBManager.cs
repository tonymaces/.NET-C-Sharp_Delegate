using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateLibrary
{
    public class DBManager
    {
        static DBConnection[] activeConnections;

        public void AddConnections()
        {
            activeConnections = new DBConnection[5];
            for (int i = 0; i < 5; i++)
            {
                activeConnections[i] =
                                new DBConnection("DBConnection" + (i + 1));
            }
        }

        public delegate void EnumConnectionsCallback(DBConnection connection);
        public static void EnumConnections(EnumConnectionsCallback callback)
        {
            foreach (DBConnection connection in activeConnections)
            {
                callback(connection);
            }
        }

    }
}
