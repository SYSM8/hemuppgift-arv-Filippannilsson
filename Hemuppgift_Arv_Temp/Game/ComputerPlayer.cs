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

        //Metod för att plocka stickor 
        public override int takePins(Board board)
        {
            //Hämta antal stickor som finns kvar
            int noPins = board.getNoPins();

            //Skapa variabel för antal tagna stickor
            int taken;

            //Om det bara finns en sticka ska datorn ta 1
            if (noPins == 1)
            {
                taken = 1;
                Console.WriteLine($"Datorn valde att ta {taken} stickor");
            }
            else
            {
                //Datorn väljer 1-2 stickor slumpmässigt
                taken = random.Next(1, 3);
                Console.WriteLine($"Datorn valde att ta {taken} stickor");
            }


            //Anropa metoden takePins från Player
            board.takePins(taken);
            return taken;
        }
    }
}
