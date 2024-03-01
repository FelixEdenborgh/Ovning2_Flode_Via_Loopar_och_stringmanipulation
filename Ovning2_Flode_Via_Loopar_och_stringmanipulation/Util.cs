using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning2_Flode_Via_Loopar_och_stringmanipulation
{
    internal class Util
    {
        // Tar in en variable som motsvarar vad användaren stopar in typ userChoice = "hej". 
        public static void Repeat(string userChoice)
        {
            // skriver sedan ut den 10 gånger på rad och inte med rad brytning
            for(int i = 1; i <= 10; i++)
            {
                if(i < 10)
                {
                    Console.Write($"{i}.{userChoice}, ");
                }
                else
                {
                    Console.Write($"{i}.{userChoice}");
                }
                
            }
        }
    }
}
