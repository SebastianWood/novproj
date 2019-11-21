using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjekt_Sebastian_Wood
{
    class Program
    {
        static void Main(string[] args)
        {

            Random generator = new Random();

            int damage = generator.Next(0, 5);

            //presentera fighter och skriv in klassen person här. 
            Fighter fighter = new Fighter();

            fighter.PrintInfo();

            Console.WriteLine("Skriv in namn på fighter: ");

            
            {
                fighter.namn = Console.ReadLine();

            };

            Console.WriteLine("" + fighter.namn + "!");

            Console.WriteLine("Skriv in namn på fighter2: ");

            Fighter fighter2 = new Fighter();
            {
                fighter2.namn = Console.ReadLine();

            };


            Console.WriteLine("" + fighter2.namn + "!");

            Console.ReadLine();


            Console.WriteLine("Nu börjar fighten! ");





        }
    }
}
