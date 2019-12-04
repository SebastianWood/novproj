using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp; //är bibloteket för requesten i koden. 
using Newtonsoft.Json; //omvandlar JSON kod (javascript objekt notering) till csharp kod.

namespace NovemberProjekt_Sebastian_Wood
{
    class Program
    {
        static void Main(string[] args)
        {

            Fighter fighter3 = new Fighter();

            fighter3.namePokemon = "wood";  //metoder inom klasser

            string names = fighter3.TaNamn(); //tar TaNamn från 

            Console.WriteLine(names);

            Console.ReadLine();

            

            Pokemon namn = new Pokemon();

            

            Console.WriteLine(fighter3.namePokemon);

            Console.ReadLine();
            

            RestClient client = new RestClient("https://pokeapi.co/api/v2/"); //själva klienten alltså hemsidan där genom api all information hämtas.

            RestRequest request = new RestRequest("pokemon/bulbasaur"); //requestar information genom api från denna karaktär som skrivs

            

            IRestResponse response = client.Get(request); //innebär att man använder klienten för att hämta (get) själva requesten genom RestClient ovan

           
            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(response.Content); //innebär att man utgår från klassen Pokemon och skapar en instans av klassen. Hämtar då nödvändig information från api genom klassen.




            Console.WriteLine(pokemon.name + " valdes!");

            Console.WriteLine("Nu, skriv in en Pokemon karaktär!");
            //string namn = Console.ReadLine();
            Console.ReadLine();

            RestRequest request2 = new RestRequest(/*"pokemon/namn"*/); //här kan användaren requesta vilken pokemon den vill utifrån api databasen. 



            IRestResponse response2 = client.Get(request2); //innebär att man använder klienten för att hämta (get) själva requesten genom RestClient ovan


            Pokemon spelare = JsonConvert.DeserializeObject<Pokemon>(response2.Content); //innebär att man utgår från klassen Pokemon och skapar en instans av klassen. Hämtar då nödvändig information från api genom klassen.

            Console.WriteLine("Du valde: " + spelare.name);
            Console.ReadLine();


            //gör att arenan är en klass. 

            Random generator = new Random();

            int damage = generator.Next(0, 5);

            //presentera fighter och skriv in klassen person här. 


            Fighter fighter = new Fighter();



            Console.WriteLine("Skriv in namn på din fighter: ");

            
            {
                fighter.namn = Console.ReadLine();

            };

            Console.WriteLine("" + fighter.namn + "!");



            Console.WriteLine(fighter.namn + " aka " + pokemon.name + "!");
            

            Console.ReadLine();


            Console.WriteLine("Nu börjar fighten! ");








        }
    }
}
