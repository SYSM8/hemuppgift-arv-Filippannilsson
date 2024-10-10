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

            //Starta spelet med 10 pinnar
            board1.setUp(10);

            ////Testa att ta först 1 och sedan 2 pinnar
            //board1.takePins(1);
            //board1.takePins(2);

            ////Skriv ut antal pinnar som finns kvar
            //Console.WriteLine($"Det finns {board1.getNoPins()} pinnar kvar på brädet");


            //Skapa ett HumanPlayer-objekt
            HumanPlayer player1 = new HumanPlayer("Filippa");
            player1.takePins(board1);
        }

    }
}
