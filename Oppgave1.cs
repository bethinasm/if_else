using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Oppgave1
{
    public void Run()
    {
        /*  Oppgave 1:
            Lag en metode som tar imot to tall og returnerer true dersom tallene er like.
        */
        Console.WriteLine("OPPGAVE 1:");

        Console.WriteLine("Skriv inn ett tall");
        var numberInput1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Supert, nå skriv inn et til!");
        var numberInput2 = Convert.ToInt32(Console.ReadLine());
        IsNumberEqual(numberInput1, numberInput2);

        

        Console.ReadKey();
    }
    private void IsNumberEqual(int numberInput1, int numberInput2)
    {
        if (numberInput1 == numberInput2)
        {
            Console.WriteLine("Tallene du skrev inn er like!");
        }
        else
        {
            Console.WriteLine("Tallene du skrev inn er ikke like");
        }
    }
    }
}