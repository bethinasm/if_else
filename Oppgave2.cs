using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Oppgave2
    {
        public void Run()
        {

            /*  Oppgave 2:
                Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike,
                og returnerer tallene multiplisert med hverandre dersom de er like
            */

            Console.WriteLine("OPPGAVE 2:");

            Random rand = new Random();
            int RandomNr1 = rand.Next(1, 11);
            int RandomNr2 = rand.Next(1, 11);
            Console.WriteLine($"First random number is: {RandomNr1}");
            Console.WriteLine($"Second random number is: {RandomNr2}");

            int result = CheckNumbers(RandomNr1, RandomNr2);
            Console.WriteLine($"The result is: {result}.");

            
            Console.ReadKey();
        }
        private int CheckNumbers(int RandomNr1, int RandomNr2)
        {
            if (RandomNr1 == RandomNr2)
            {
                Console.WriteLine("The numbers were equal, so they were multiplied.");
                return RandomNr1 * RandomNr2;
            }
            else
            {
                Console.WriteLine("The numbers were not equal, so they were added together.");
                return RandomNr1 + RandomNr2;
            }
        }
    }
}