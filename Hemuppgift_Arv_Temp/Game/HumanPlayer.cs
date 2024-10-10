using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class HumanPlayer : Player
    {
        //Konstruktor 
        public HumanPlayer(string userId) : base(userId)
        {

        }

        //Metod för att plocka stickor 
        public override int takePins(Board board)
        {
            //Användaren anger antal stickor att ta, spara i variabel taken
            Console.WriteLine("Ange hur många stickor du vill plocka: ");
            int taken = Convert.ToInt32(Console.ReadLine());

            //Anropa metoden takePins från Player
            board.takePins(taken);
            return taken;
        }
    }
}
