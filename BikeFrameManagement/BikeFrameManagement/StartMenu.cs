using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFrameManagement
{
    internal class StartMenu : Menu
    {
        //Override abstrakte Methode
        public override void DisplayMenu()
        {
            Console.WriteLine("BikeFrame Management");
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            Console.WriteLine("Erstelle ein neues Profil oder lade ein bestehendes:");
            Console.WriteLine();
            Console.WriteLine("[1] Neues Profil erstellen");
            Console.WriteLine("[2] Bestehendes Profil laden");
            Console.WriteLine();
           
            Input();
        }

        private void Input()
        {

            Menu nextMenu;
            while (true)
            {
                Console.Write("Eingabe: ");
                string input = Console.ReadLine();
                bool correctInput = true;
                switch (input)
                {
                    case "1":
                        nextMenu = new CreateProfileMenu();
                        break;
                    case "2":
                        nextMenu = new LoadProfileMenu();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Falsche Eingabe. Wähle aus Option [1] und [2]!");
                        Console.ForegroundColor = ConsoleColor.White;
                        correctInput = false;
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
