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

        //Metod för att plocka pinnar 
        public override int takePins(Board board)
        {
            //Användaren anger antal pinnar att ta, spara i variabel taken
            Console.WriteLine("Ange hur många pinnar du vill plocka: ");
            int taken = Convert.ToInt32(Console.ReadLine());

            //Anropa metoden takePins
            board.takePins(taken);
            return taken;
        }
    }
}
