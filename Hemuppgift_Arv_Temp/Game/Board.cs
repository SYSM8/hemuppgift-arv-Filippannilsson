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

        public int noPins { get; set; } //Antal pinnar

        //Maxvärde på startPins
        int Maxvalue = 50;

        
        //Metoder

        //Antalet pinnar som finns på brädet när spelet börjar
        public void setUp(int startPins)
        {

            //Om tillåtet antal pinnar vid start
            if (startPins >= 0 && startPins <= Maxvalue)
            {
                //Sätt antal pinnar till det antal som finns från början
                noPins = startPins;
                Console.WriteLine($"Antalet pinnar på brädet: {startPins}");
            }
            else
            {
                //Skriv ut felmeddelande
                Console.WriteLine("Antalet pinnar måste vara mellan 0-50");
            }
        }

        //Metod för att ta ett visst antal pinnar från brädet
        public void takePins(int takenPins)
        {
            //Om användaren väljer 1 eller 2 pinnar
            if ((takenPins == 1 || takenPins == 2) && takenPins <= noPins)
            {
                //Uppdatera antal pinnar
                noPins = noPins - takenPins;

                //Skriv ut antal tagna pinnar och antal som finns kvar
                Console.WriteLine($"Du har tagit {takenPins} pinnar. Det finns {noPins} kvar på brädet.");
            }
            else if (takenPins > noPins)
            {
                //Skriv ut felmelmeddelande
                Console.Write("Det finns inte så många pinnar på brädet");
            }
            else
            {
                //Skriv ut felmeddelande
                Console.WriteLine("Du får endast välja 1 eller 2 pinnar");
            }
        }

        //Returnera antalet pinnar som finns på brädet 
        public int getNoPins()
        {
            return noPins;
        }
    }
}
