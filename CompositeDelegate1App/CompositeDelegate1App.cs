using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DelegateLibrary;

namespace CompositeDelegate1App
{
    class CompositeDelegate1App
    {
        public static void LogEvent(Part part)
        {
            Console.WriteLine("\tregistrando evento...");
        }
        public static void EmailPurchasingMrg(Part part)
        {
            Console.WriteLine("\tenviando correo al responsable de compars...");
        }

        public static void Main()
        {
            InventoryManager mrg = new InventoryManager();
            InventoryManager.OutOfStokExcepttionMethod LogEventCallback =
                new InventoryManager.OutOfStokExcepttionMethod (LogEvent);

            InventoryManager.OutOfStokExcepttionMethod
                EmailPurchasingMrgCallback = new
                InventoryManager.OutOfStokExcepttionMethod
                (EmailPurchasingMrg);

            InventoryManager.OutOfStokExcepttionMethod
                OnHandExceptionEventsCallback =
                EmailPurchasingMrgCallback + LogEventCallback;

            mrg.ProcessInventory(OnHandExceptionEventsCallback);

        }
    }
}
