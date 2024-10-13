using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        //Egenskaper

        public int noPins { get; set; } //Antal stickor

        //Maxvärde på startPins
        int Maxvalue = 50;

        
        //Metoder

        //Antalet stickor som finns på brädet när spelet börjar
        public void setUp(int startPins)
        {

            //Om tillåtet antal stickor vid start
            if (startPins >= 0 && startPins <= Maxvalue)
            {
                //Sätt antal stickor till det antal som finns från början
                noPins = startPins;
                Console.WriteLine($"Antalet stickor på brädet vid start: {startPins}");
            }
            else
            {
                //Skriv ut felmeddelande
                Console.WriteLine("Antalet stickor måste vara mellan 0-50");
            }
        }

        //Metod för att ta ett visst antal stickor från brädet
        public void takePins(int takenPins)
        {
            //Om användaren väljer 1 eller 2 stickor
            if ((takenPins == 1 || takenPins == 2) && takenPins <= noPins)
            {
                //Uppdatera antal stickor
                noPins = noPins - takenPins;

                //Skriv ut antal tagna stickor och antal som finns kvar
                Console.WriteLine($"Det finns {noPins} kvar på brädet.");
            }
            else if (takenPins > noPins)
            {
                //Skriv ut felmelmeddelande
                Console.Write("Det finns inte så många stickor på brädet");
            }
            else
            {
                //Skriv ut felmeddelande
                Console.WriteLine("Du får endast välja 1 eller 2 stickor");
            }
        }

        //Returnera antalet stickor som finns på brädet 
        public int getNoPins()
        {
            return noPins;
        }
    }
}
