using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFrameManagement
{
    internal class ShowAvailableFramesMenu : Menu
    {
        public override void DisplayMenu()
        {
            Console.WriteLine("Vorhandene Einträge in der Datenbank: ");
            Console.WriteLine("-------------------------------------");
            ShowAvailableFrames();
            Console.WriteLine();
            Console.WriteLine("Drücke eine beliebige Taste um ins Hauptmenü zurück zu kehren.");
            Console.ReadKey();
            Menu nextMenu = new MainMenu();
        }

        private void ShowAvailableFrames()
        {
            if (Profilmanager.CurrentProfile.Frames.Count > 0)
            {
                foreach (Frame f in Profilmanager.CurrentProfile.Frames)
                {
                    Console.WriteLine("-" + f.Manufacturer + " " + f.Model);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Es sind noch keine Daten zum anzeigen vorhanden! Füge zuerst einen Datensatz hinzu!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}
