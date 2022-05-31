using System.Collections.Generic;
using System.Dynamic;

namespace Trond_Marius_Spill
{
    public class Terrorists
    {

        private static int _teamsize = 5;
        public int timer;

        
        public Terrorists()
        {
            List<player> T = new List<player>();
            for (int i = 0; i < _teamsize; i++)
            {
                T.Add(new player());
            }
                
        }
        
        public static bool FindBombSite()
        {
            if (Program.IsSuccessful(10))
            {
                Plantbomb();
                return true;
            }
            else return false;
        }

        public static bool KillCounterTerrorist()
        {
            if (Program.IsSuccessful(7))
            {
                _teamsize--;
                return true;
                
            }

            else return false;
        }

        public static void Plantbomb()
        {
            
        }

        
    }
}