using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFrameManagement
{
    internal class DeleteFrameMenu : Menu
    {
        public override void DisplayMenu()
        {
            bool dataAvailable = true;
            Console.WriteLine("Bestehende Einträge aus Datenbank löschen:");
            Console.WriteLine("------------------------------------------");
            if (DataAvailable())
            {
                ShowAvailableFrames();
                int frameNrToDelete = Input();
                Profilmanager.CurrentProfile.Frames.Remove(Profilmanager.CurrentProfile.Frames[frameNrToDelete]);
                Profilmanager.SaveProfile(Profilmanager.CurrentProfile);
                //Add Eventhandler für Meldung: Daten erfolgreich hinzugefügt!
                Menu nextMenu = new MainMenu(); 
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keine Daten zum Löschen vorhanden! Füge erst einen Datensatz hinzu.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            

        }

        private bool DataAvailable()
        {
            if (Profilmanager.CurrentProfile.Frames.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ShowAvailableFrames()
        {
                foreach (Frame f in Profilmanager.CurrentProfile.Frames)
                {
                    Console.WriteLine("-" + f.Manufacturer + " " + f.Model);
                }
        }

        private int Input()
        {
            int frameNr = -1;
            string input;
            while (true)
            {
                int i = 0;
                Console.Write("Gebe den Modellnamen des zu löschenden Datensatzes ein:");
                input = Console.ReadLine();
                frameNr = Profilmanager.CurrentProfile.Frames.FindIndex(f => f.Model == input);
                if (frameNr != -1)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fehler! Der Modellname ist nicht keinem Datensatz zugewiesen!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return frameNr;
        }
    }
}
