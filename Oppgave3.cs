using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Oppgave3
    {
        public void Run()
        {

            /*  Oppgave 3:
                Lag en metode som tar inn to int verdier. Dersom en av de, eller summen til int verdiene blir 30,
                skal metoden returnere true. Ellers returnerer metoden false
            */

            Console.WriteLine("OPPGAVE 3");
            Console.ReadKey();

            Random random = new Random();
            int RandomNr3 = random.Next(1, 51);
            int RandomNr4 = random.Next(1, 51);
            Console.WriteLine($"First random number is: {RandomNr3}");
            Console.WriteLine($"Second random number is: {RandomNr4}");


            Console.WriteLine("Does either number or their sum equal 30? ");

            CheckIf30(RandomNr3, RandomNr4);

        }
        private bool CheckIf30(int num3, int num4)
        {
            if (num3 == 30 || num4 == 30 || (num3 + num4) == 30)
            {
                Console.WriteLine("Condition met: Returning true");
                return true;
            }
            else
            {
                Console.WriteLine("Condition not met: Returning false");
                return false;
            }
        }
    }
}