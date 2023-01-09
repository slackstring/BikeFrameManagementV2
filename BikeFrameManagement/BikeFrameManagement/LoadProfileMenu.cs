using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFrameManagement
{
    internal class LoadProfileMenu :Menu
    {
        public override void DisplayMenu()
        {
            Console.WriteLine("Profil laden:");
            Console.WriteLine("--------------");
            Console.WriteLine();
            Console.WriteLine("Bestehende Profile:");
            Menu nextMenu;
            int nProfil = Profilmanager.ShowExistingProfiles();
            if (nProfil > 0)
            {
                string profileName = GetInput();
                Profilmanager.LoadProfile(profileName);
                nextMenu = new MainMenu();
            }
            else
            {
                nextMenu = new StartMenu();
            }
            
            

        }

        private string GetInput()
        {
            string profileName;
            while (true)
            {
                Console.Write("Eingabe: ");
                profileName = Console.ReadLine();
                if (Profilmanager.CheckIfProfileExists(profileName))
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Fehler! Das Profil exisitert nicht!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return profileName;
        }
    }
}
