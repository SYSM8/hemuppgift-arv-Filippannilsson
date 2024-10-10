//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class ComputerPlayer : Player
    {
        Random random = new Random();

        //Konstruktor 
        public ComputerPlayer(string userId) : base(userId)
        {

        }

        //Metod för att plocka pinnar 
        public override int takePins(Board board)
        {
            //Skapa variabel som låter datorn välja 1-2 pinnar
            int taken = random.Next(1, 3);
            Console.WriteLine($"Datorn valde att ta {taken} pinnar");

            //Anropa metoden takePins från Player
            board.takePins(taken);
            return taken;
        }
    }
}
