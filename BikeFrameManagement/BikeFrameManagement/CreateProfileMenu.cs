using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFrameManagement
{
    internal class CreateProfileMenu : Menu
    {
        public override void DisplayMenu()
        {
            Console.WriteLine("Neues Profil erstellen:");
            Console.WriteLine("-----------------------");
            string name = Input();
            Profilmanager.CreateProfileMenu(name);
            Menu nextMenu = new MainMenu();
        }

        private string Input()
        {
            string name;
            while (true)
            {
                Console.Write("Gebe einen Namen für das Profil ein: ");
                name = Console.ReadLine();
                if (! Profilmanager.CheckIfProfileExists(name + ".bfm"))
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Fehler! Es existiert bereits ein Profil mit dem Namen: " + name + " !");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return name;
        }


    }
}
