using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFrameManagement
{
    internal class MainMenu : Menu
    {
        public override void DisplayMenu()
        {
            
            Console.WriteLine("Hauptmenü:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Aktuelles Profil: " + Profilmanager.CurrentProfile.ProfileName + ".bfm");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("[1] Frame hinzufügen");
            Console.WriteLine("[2] Vorhandene Frames ansehen");
            Console.WriteLine("[3] Frame löschen");
            Console.WriteLine("[4] Frames vergleichen");
            Console.WriteLine("[5] Zurück ins Start Menü");
            userInput();

        }

        private static void userInput()
        {
            string input;
            Menu nextMenu;
            while (true)
            {
                bool correctInput = true;
                Console.WriteLine();
                Console.Write("Eingabe: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        nextMenu = new AddFrameMenu();
                        
                        break;
                    case "2":
                        nextMenu = new ShowAvailableFramesMenu();
                        break;
                    case "3":
                        nextMenu = new DeleteFrameMenu();
                        break;
                    case "4":
                        //nextMenu = new CompareFramesMenu();
                        break;
                    case "5":
                        nextMenu = new StartMenu();
                        break;
                    default:
                        correctInput = false;
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Falsche Eingabe! Wähle ein vorhandene Option aus [1-4]");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                if (correctInput)
                {
                    break;
                }
            }
        }
    }
}
