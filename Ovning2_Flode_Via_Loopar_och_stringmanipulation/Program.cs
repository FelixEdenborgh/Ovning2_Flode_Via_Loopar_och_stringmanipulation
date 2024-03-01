namespace Ovning2_Flode_Via_Loopar_och_stringmanipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till denna bio \nHär finns en massa bra filmer kom och skriv in er!\nVem vet ni kanske kan få det biligare!");
            Console.WriteLine();
            Console.WriteLine("I denna biljet automat så ser ni en huvudmenyn. \nFör att kunna navigera runt i denna huvudmenyn behöver ni trycka på respektive siffra som hör till respektive meny.");

            
            bool exit = false;
            string userInput = string.Empty;
            string ageOfUser = string.Empty;
            string howmany = string.Empty;
            string companyages = string.Empty;
            string repeat = string.Empty;



            // while loop som jobbar så länge exit inte är lika med true
            while (exit != true) 
            {
                // menyn
                Console.WriteLine("\nHuvudmeny: ");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Age check");
                Console.WriteLine("2. Pris för sälskap 2 personer+");
                Console.WriteLine("3. Repetera en sträng 10 gånger");
                Console.Write(": ");


                // tar in användar input i string
                userInput = Console.ReadLine();

                // omvandlar string inputen och testar att göra den till en int, om det inte går så skickar den ett fel meddelande och man får försöka igen.
                if(int.TryParse(userInput, out int userChoice))
                {
                    // switch som sköter om user input dvs i detta laget "userChoice"
                    switch (userChoice)
                    {
                        case 0:
                            exit = true;
                            break;

                        case 1:
                            // tar in en string och kollar så att den inte består av bokstäver utan siffror
                            Console.WriteLine("Ange older: ");
                            ageOfUser = Console.ReadLine();
                            // omvandlar strängen till int om det går annars går till else och skriver "fel input testa igen"
                            if (int.TryParse(ageOfUser, out int age))
                            {
                                Console.WriteLine($"Du är av åldern {age} och ditt biljet pris är {ageCheck.CheckAge(age)}kr");
                                
                            }
                            else { Console.WriteLine("Fel input testa igen!"); }
                            break;

                        case 2:
                            // kollar hur många de är i sälskapet
                            Console.WriteLine("Ange hur många ni är: ");
                            howmany = Console.ReadLine();
                            // kollar om det är en sträng eller int, och om det går att omvandla till int.
                            if(int.TryParse(howmany, out int howmanyChoice))
                            {
                                // får tillbaka hur mycket kostnad det blev.
                                int kostnad = ageCheck.GroupPrice(howmanyChoice);
                                // kollar så att den som kommer tillbaka är störe än 0 och isåfall skriver ut den, annars gör den inget.
                                if (kostnad >= 0)
                                {
                                    Console.WriteLine($"Din grupps på {howmanyChoice} personer har en total kostnad på: {kostnad}kr");
                                }    
                            }
                            else { Console.WriteLine("Fel input testa igen!"); }
                            break;
                        case 3:
                            // Kollar vilket ord eller mening som ska repeteras 10 gånger.
                            Console.WriteLine("Skriv ett ord/ mening som du vill ha repeterad 10 gånger: ");
                            repeat = Console.ReadLine();
                            Util.Repeat(repeat);
                            break;

                        default:
                            Console.WriteLine("Felaktig input");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Voops det där var en text string och inte en siffra. Försök igen!");
                }
            }

            // mental note, vi är på sista sidan i uppgiften "meny val 2"
        }
    }
}
