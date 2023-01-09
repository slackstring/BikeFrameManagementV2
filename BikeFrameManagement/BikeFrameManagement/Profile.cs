using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFrameManagement
{
    [Serializable]
    internal class Profile
    {
        //Eigenschaften
        public string ProfileName { get; set; }
        public List<Frame> Frames { get; set; }

        //Konstruktor
        public Profile(string profileName)
        {
            ProfileName = profileName;

            Frames = new List<Frame>();
        }
    }
}
