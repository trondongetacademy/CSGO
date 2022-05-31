using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Trond_Marius_Spill
{
    public class CounterTerrorists
    {
       
        private int _defusing =0;
        private int _teamsize = 5;
        public CounterTerrorists()
        {
            List<player> CT = new List<player>();
            for (int i = 0; i < _teamsize; i++)
                CT.Add(new player());
         
        }

        public bool DefuseBomb()
        {
  
            if (_defusing == 5)
                return true;
            else return false;

        }

        public static bool KillTerrorist(int Chance, List<player> T)
        {
            if (Program.IsSuccessful(Chance))
            {
                T.Remove(T[0]);
            }
           
        }
    }
}