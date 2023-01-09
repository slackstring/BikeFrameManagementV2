using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFrameManagement
{
    [Serializable]
    internal class Frame
    {
        //Eigenschaften
        public string Manufacturer { get; set; }
        
        public string Model { get; set; }

        public string Material { get; set; }

        //Konstruktor
        public Frame(string manufacturer, string model, string material)
        {
            Manufacturer = manufacturer;
            Model = model;
            Material = material;
        }


    }
}
