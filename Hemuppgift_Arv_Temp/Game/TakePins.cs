namespace Hemuppgift_Arv_Temp.Game
{
    public class TakePins
    {
        /* Frågor att svara på:
        1. Klassen Player är superklass till klasserna Humanplayer och ComputerPlayer.
        2. Vilka av följande tilldelningssatser är korrekta?
            Player p = new HumanPlayer("Alicent");
            HumanPlayer p = new HumanPlayer("Rhaenyra");
        */
        static void Main(string[] args)
        {
            bool newGame = true;

            while (newGame)
            {
                //Skapa ett Board-objekt
                Board board1 = new Board();

                //Skapa ett HumanPlayer-objekt
                HumanPlayer player1 = new HumanPlayer("Filippa");

                //Skapa ett Playerobjekt för datorn
                Player computer = null;

                //Skriv ut välkomstmeddelande
                Console.WriteLine($"Välkommen {player1.getUserId()}! Du ska nu spela ett spel som " +
                    $"går ut på att plocka upp den sista stickan från ett bord. Du får ta 1-2 stickor " +
                    $"varje gång, den som tar den sista stickan vinner.");


                bool validChoice = false;
                // Loopar tills ett giltigt val görs
                while (!validChoice)
                {
                    // Be användaren att välja typ av dator
                    Console.WriteLine("Välj typ av dator:");
                    Console.WriteLine("1. Vanlig Dator");
                    Console.WriteLine("2. Smart Dator");
                    string datorVal = Console.ReadLine();

                    // Skapa datorn baserat på användarens val
                    switch (datorVal)
                    {
                        case "1":
                            computer = new ComputerPlayer("Computer");
                            validChoice = true;
                            break;
                        case "2":
                            computer = new SmartComputerPlayer("SmartComputer");
                            validChoice = true;
                            break;
                        default:
                            Console.WriteLine("Ogiltigt val, välj igen.");
                            break;
                    }
                }


                //Starta spelet med 10 pinnar
                board1.setUp(10);

                while (board1.getNoPins() > 0)
                {
                    //Låt player1 spela en omgång
                    player1.takePins(board1);

                    //Meddelande om player1 vunnit spelet
                    if (board1.getNoPins() == 0)
                    {
                        Console.WriteLine("Grattis, du vann!");
                        break;
                    }

                    //Låt computer spela en omgång
                    computer.takePins(board1);


                    //Meddelande om computer vunnit spelet
                    if (board1.getNoPins() == 0)
                    {
                        Console.WriteLine("Spelet är slut, datorn vann");
                        break;
                    }


                }

                //Fråga användaren om ny spelomgång
                Console.WriteLine("Vill du spela igen? Ja/Nej:");
                string newGameAnswer = Console.ReadLine().ToLower();

                if (newGameAnswer != "ja")
                {
                    newGame = false;
                }
            }
            
        }

    }
}
