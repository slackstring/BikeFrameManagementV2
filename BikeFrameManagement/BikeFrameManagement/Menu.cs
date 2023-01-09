using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFrameManagement
{
    abstract class Menu
    {
        //Konstruktor
        public Menu()
        {
            Console.Clear();
            DisplayMenu();
        }

        //Methode
        public abstract void DisplayMenu();
 
    }
}
