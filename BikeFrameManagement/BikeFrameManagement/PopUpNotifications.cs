using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFrameManagement
{
    internal class PopUpNotifications
    {
        public void FrameAdded()
        {
            Console.WriteLine();
            Console.WriteLine("Datensatz erfolgreich hinzugefügt!");
            Console.WriteLine("Drücke eine beliebige Taste zum Fortfahren!");
            Console.ReadKey();
        }

        public void FrameDeleted()
        {
            Console.WriteLine("Datensatz erfolgreich gelöscht!");
            Console.WriteLine("Drücke eine beliebige Taste zum Fortfahren!");
            Console.ReadKey();
        }
    }
}
