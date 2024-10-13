using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class SmartComputerPlayer : Player
    {
        //Konstruktor
        public SmartComputerPlayer(string userId) : base(userId)
        {

        }

        //Metod för att plocka stickor
        public override int takePins(Board board)
        {
            //Hämtar aktuella antalet stickor
            int noPins = board.getNoPins();
            int taken;

            //Om det finns 2 stickor kvar, ta båda
            if (noPins == 2)
            {
                taken = 2;
                Console.WriteLine($"Datorn valde att ta {taken} stickor");
            }
            //Om det finns 1 sticka kvar, ta den
            else if (noPins == 1)
            {
                taken = 1;
                Console.WriteLine($"Datorn valde att ta {taken} stickor");
            }
            //Om antal stickor inte kan delas med 3
            else if (noPins % 3 != 0)
            {
                //Tar stickor för att lämna antal delbart med 3 och försämra motståndarens odds
                taken = noPins % 3;
                Console.WriteLine($"Datorn valde att ta {taken} stickor");
            }
            else
            {
                Random random = new Random();

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
