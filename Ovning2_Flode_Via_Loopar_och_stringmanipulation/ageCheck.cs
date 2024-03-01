using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning2_Flode_Via_Loopar_och_stringmanipulation
{
    internal class ageCheck
    {
        public static int CheckAge(int age)
        {
            // 3 ints med ett världe på dem var
            int ungdomsPris = 80;
            int pensionärPris = 90;
            int standartPris = 120;

            int biljetPris = 0;

            // kollar om åldern är under 20 och över 5, om det är så så räknas personen till "ungdom" och får betala ungdomspriset
            if ((age < 20) && (age > 5))
            {
                biljetPris = ungdomsPris;
            }
            else
            {
                // Kollar om åldern är störe än 64 och mindre än 100, och om det är så är det pensionärspris.
                if ((age > 64) && (age <= 100))
                {
                    biljetPris = pensionärPris;
                }
                // Kollar om åldern är störe eller lika med 20 och lägre eller lika med 64, och isåfall är det standardpris
                else if ((age >= 20) && (age <= 64))
                {
                    biljetPris = standartPris;
                }
                // är Personen mindre än 5, och störe än 100 så är det gratis inträdde.
                else
                {
                    biljetPris = 0;
                }
            }
            return biljetPris;
        }

        public static int GroupPrice(int howmany)
        {
            // skapa en lista som sparar in ints på varje persons ålder
            List<int> list = new List<int>();

            string input = string.Empty;
            int age = 0;
            int sum = 0;

            // håller koll på hur många gånger den ska fråga personen
            Console.WriteLine("Hur gamla är personerna?");
            for (int i = 1; i <= howmany; i++)
            {
                Console.WriteLine($"Person {i}: ");
                // kollar så att det är en sträng som går att omvandla till int och inget annat.
                input = Console.ReadLine();
                if (int.TryParse(input, out age))
                {
                    list.Add(age);
                }
                else { 
                    Console.WriteLine("Fel inmatning här tar vi bara siffror!"); 
                    return -1;
                    
                }
                
            }
            
            // Loopar igenom listan och adderar priset genom att få priset från checkAge metoden
            foreach(int item in list)
            {
                sum += CheckAge(item);
            }

            // skickar tillbaka gruppens kostnad
            return sum;
        }
    }
}
