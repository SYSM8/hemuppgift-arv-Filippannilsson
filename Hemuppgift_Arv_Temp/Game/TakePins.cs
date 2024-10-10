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

        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            //Skapa ett Board-objekt
            Board board1 = new Board();

            //Skapa ett HumanPlayer-objekt och ett ComputerPlayer-objekt
            HumanPlayer player1 = new HumanPlayer("Filippa");
            ComputerPlayer computer = new ComputerPlayer("datorn");

            //Skriv ut välkomstmeddelande
            Console.WriteLine($"Välkommen {player1.getUserId()}! Du ska nu spela ett spel som " +
                $"går ut på att plocka upp den sista stickan från ett bord. Du får ta 1-2 stickor " +
                $"varje gång, den som tar den sista stickan vinner.");

            //Starta spelet med 10 pinnar
            board1.setUp(10);

            while (board1.getNoPins() > 0)
            {
                //Låt player1 spela en omgång
                player1.takePins(board1);

                //Meddelande om player1 vunnit spelet
                if (board1.getNoPins() == 0)
                {
                    Console.WriteLine($"Spelet är slut, {player1.getUserId()} vann");
                    break;
                }

                //Låt computer spela en omgång
                computer.takePins(board1);

                //Meddelande om computer vunnit spelet
                if (board1.getNoPins() == 0)
                {
                    Console.WriteLine($"Spelet är slut, {computer.getUserId()} vann");
                    break;
                }


            }
                       
        }

    }
}
