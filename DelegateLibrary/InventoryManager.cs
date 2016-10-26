using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DelegateLibrary
{
    public class InventoryManager 
    {
        protected const int MIN_ONHAND = 50;
        public Part[] parts;
        public InventoryManager()
        {
            parts = new Part[5];

            for (int i = 0; i < 5; i++)
            {
                Part part = new Part("Sede" + (i + 1));
                Thread.Sleep(10); //La aleatoriedad toma como semilla el tiempo
                parts[i] = part;
                Console.WriteLine("Sumando a sede '{0}' el disponibile = {1}",
                                    part.sku, part.onhand);
            }

            
        }

        public delegate void OutOfStokExcepttionMethod(Part par);
        public void ProcessInventory(OutOfStokExcepttionMethod exception)
        {
            Console.WriteLine("\nProcesando inventario...");
            foreach (Part part in parts)
            {
                if (part.onhand < MIN_ONHAND)
                {
                    Console.WriteLine
                        ("Disponible {0} ({1}) por debajo del limite{2}",
                         part.sku, part.onhand, MIN_ONHAND);
                    exception(part);
                }
            }
        }


      
    }
}
