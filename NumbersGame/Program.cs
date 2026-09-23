namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esa Mourujärvi BUV26

            Random random = new Random();
            int guessNumber = random.Next(1, 21);
            int CheckGuess = 0;
            int tries = 5;


            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Console.WriteLine("Gissa på ett nummer från 1 till 20?");

            while (CheckGuess != guessNumber && tries > 0)
            {

                string input = Console.ReadLine()!;

                if (!int.TryParse(input, out CheckGuess))
                {
                    Console.WriteLine("Skriv endast giltiga nummer");
                    continue;
                }

                else if (CheckGuess < guessNumber)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                }
                else if (CheckGuess > guessNumber)
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }
                else 
                {
                    Console.WriteLine("Wohoo! Du gjorde det!");
                }

                tries--;

            }
                if (CheckGuess != guessNumber)
            {
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
            }


        }
    }
}
