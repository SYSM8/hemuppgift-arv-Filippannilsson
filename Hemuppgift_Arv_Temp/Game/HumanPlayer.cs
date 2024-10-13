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
            //Initialiserar variabel för antal stickor som plockats
            int taken = 0;
            //Variabel för att kontrollera giltig inmatning
            bool validInput = false;

            //Loop som körs tills användaren matat in giltig siffra
            while (!validInput)
            {
                try
                {
                    //Användaren anger antal stickor att ta, spara i variabel taken
                    Console.WriteLine("Ange hur många stickor du vill plocka: ");
                    taken = Convert.ToInt32(Console.ReadLine());

                    if (taken < 1 || taken > 2)
                    {
                        Console.WriteLine("Du måste ange ett heltal, 1 eller 2");
                    }
                    else if (taken > board.getNoPins())
                    {
                        // Felmeddelande om de valt fler stickor än vad som finns kvar
                        Console.WriteLine("Det finns inte så många stickor på brädet. Försök igen.");
                    }
                    else
                    {
                        //Anropa metoden takePins från Player
                        board.takePins(taken);
                        validInput = true; //Bryter loopen vid korrekt inmatning
                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Du måste ange ett heltal 1-2");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            return taken;
        }
    }
}
