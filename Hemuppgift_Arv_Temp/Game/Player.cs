using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {
        //Egenskaper
        public string userId { get; set; }

        //Konstruktor
        public Player (string userId)
        {
            this.userId = userId;
        }
        
        //Metod för att returnera användar-Id
        public string getUserId()
        {
            return userId;
        }

        //Metod för att ta stickor, måste implementeras av HumanPlayer och ComputerPlayer
        public abstract int takePins(Board board); 
        
    }
}
