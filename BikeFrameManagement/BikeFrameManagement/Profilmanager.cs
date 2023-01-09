using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BikeFrameManagement
{
    [Serializable]
     class Profilmanager
    {
        //Eigenschaften 
        public static Profile CurrentProfile { get; private set; }

        //Methoden
        public static void CreateProfileMenu (string profileName)
        {
            CurrentProfile = new Profile(profileName);
            SaveProfile(CurrentProfile);
        }

        public static void SaveProfile(Profile profile)
        {
            string filePath = AppContext.BaseDirectory + profile.ProfileName + ".bfm";
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            
            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    binaryFormatter.Serialize(stream, profile);
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        public static void LoadProfile(string profileName)
        {
            string filePath = AppContext.BaseDirectory + profileName;
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    CurrentProfile = (Profile)binaryFormatter.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        public static bool CheckIfProfileExists(string profileName)
        {
            return (File.Exists(AppContext.BaseDirectory + profileName));
        }

        public static int ShowExistingProfiles()
        {
            string[] profileFiles = Directory.GetFiles(AppContext.BaseDirectory, "*.bfm");
            if (profileFiles.Length != 0)
            {
                foreach (string p in profileFiles)
                {
                    Console.WriteLine("-" + Path.GetFileName(p));
                }
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Es sind keine Profile vorhanden!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
            }
            return (profileFiles.Length);
        }

    }
}
