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

        //Konstruktor - behövs detta??
        public Board (int noPins)
        {
            this.noPins = noPins;
        }

        //Metoder

        //Antalet pinnar som finns på brädet när spelet börjar
        public void setUp(int startPins)
        {
            if (startPins >= 0)
            {
                //Sätt antal pinnar till så många pinnar som finns från början
                noPins = startPins;
                Console.WriteLine($"Antalet pinnar på brädet: {startPins}");
            }
            else
            {
                //Skriv ut felmeddelande
                Console.WriteLine("Antalet pinnar kan inte vara lägre än 0");
            }
        }

        //Metod för att ta ett visst antal pinnar från brädet
        public void takePins(int takenPins)
        {
            if (takenPins > 0 && takenPins <= noPins)
            {
                //Uppdatera antal pinnar
                noPins = noPins - takenPins;
                Console.WriteLine($"Du har tagit {takenPins} pinnar. Det finns {noPins} kvar på brädet.");
            }
            else if (takenPins <= 0)
            {
                //Skriv ut felmelmeddelande
                Console.Write("Du måste välja 1 eller 2 pinnar");

            }
            else if (takenPins > noPins)
            {
                Console.WriteLine("Det finns inte så många pinnar på bordet");
            }
        }

        //Returnera antalet pinnar som finns på brädet 
        public int getNoPins()
        {
            return noPins;
        }
    }
}
