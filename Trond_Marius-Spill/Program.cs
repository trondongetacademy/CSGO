using System;


namespace Trond_Marius_Spill
{
    public class Program
    {       
        //var terroristOrganization = new Terrorists();
        
        
        static void Main(string[] args)
        {

            bool isTerrorists = true;
            bool bombplanted = false;
            int cycle = 0;
            Terrorists T = new Terrorists();
            CounterTerrorists CT = new CounterTerrorists();
            

            while (true)
            {
                if (isTerrorists)
                {

                    if (!bombplanted) {if ((cycle + 1) % 2 == 0) bombplanted = Terrorists.FindBombSite();  }
                       
                        
                    else Terrorists.KillCounterTerrorist();
   
                }

                else
                {
                    if (bombplanted)
                    {
                        if (AliveT()) CounterTerrorists.KillTerrorist(3,); //check for alive T ? killTerror(3) : defusebomb()
                        else 
                        { 
                            var win = CounterTerrorists.DefuseBomb();
                            if (win) Console.WriteLine("CT Wins!");
                        }
                    }
                    else CounterTerrorists.KillTerrorist(5,T);
                }



                isTerrorists = !isTerrorists;

            }

            
        }
        
        public static bool IsSuccessful(int maxValue)

            {

                Random rand = new Random();

                return rand.Next(0, maxValue) == 2;

            }
        
        
    }
}
