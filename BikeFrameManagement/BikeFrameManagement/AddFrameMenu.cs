using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFrameManagement
{
    internal class AddFrameMenu : Menu
    {
        public override void DisplayMenu()
        {
            Console.WriteLine("Frame zur Datenbank hinzufügen:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();         
            string manufacturer = InputManufacturer();
            string modell = InputModell();          
            string material = InputMaterial();
            Frame newFrame = new Frame(manufacturer, modell, material);
            Profilmanager.CurrentProfile.Frames.Add(newFrame);
            Profilmanager.SaveProfile(Profilmanager.CurrentProfile);
            Menu nextMenu = new MainMenu();
            
        }

        private string InputManufacturer()
        {
             Console.Write("Hersteller: ");
             return Console.ReadLine();            
        }

        private string InputModell()
        {
            string input;
            int frameNr = -1;
            while (true)
            {
                Console.Write("Modell: ");
                input = Console.ReadLine();
                if (Profilmanager.CurrentProfile.Frames.Count != 0)
                {
                    frameNr = Profilmanager.CurrentProfile.Frames.FindIndex(f => f.Model == input);
                }
                if (frameNr == -1)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Fehler! Das Modell ist bereits vorhanden! Modelle müssen eindeutig benannt werden!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return input;
        }

        private string InputMaterial()
        {
            string input;
            while (true)
            {
                Console.Write("Material [Alu / Carbon / Hybrid]: ");
                input = Console.ReadLine();
                if ( input == "Alu" || input == "Carbon" || input == "Hybrid")
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Falsche Eingabe! Gebe eines der drei Materialen ein!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return input;
        }
    }
}
