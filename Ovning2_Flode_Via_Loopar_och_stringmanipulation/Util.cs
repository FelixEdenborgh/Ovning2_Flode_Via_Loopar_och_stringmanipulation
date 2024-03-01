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
                // Kollar så att den sita utskriften inte har ett komma teken i sig genom att skriva de 9 första med comma på slutet och sista utan.
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

        public static string Cut(string words)
        {
            // delar orden på mellan slag och lägger in dem i en array.
            string[] splittedWords = words.Split(' ');

            // sparar det tredje i en variable och skickar tillbaka den i return
            string thirdWord = splittedWords[2];
            return thirdWord;

        }
    }
}
