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
            Fighter fighter3 = new Fighter(); //skapar från klass fighter vid namn fighter3.  

            Console.WriteLine(fighter3.TaNamn()); //tar TaNamn från Fighter klassen från metoden TaNamn.

            Console.ReadLine(); //pausar programmet så att man måste trycka sig vidare. 

            string names = fighter3.TaNamn() + " TE17A"; //skapar en string vid namn names som tar från TaNamn metoden från fighter samt inkluderar TE17A

            Console.WriteLine(names); //skriver ut stringen som skrevs ovan. 

            Console.ReadLine();
            
            fighter3.namePokemon = "wood";  //med hjälp av arv (subklass) innehåller fighter namePokemon vilket gör att information från pokemon har skapats och kan användas i main.

            Console.WriteLine(fighter3.namePokemon);

            Console.ReadLine();

            Pokemon namn = new Pokemon(); 


            RestClient client = new RestClient("https://pokeapi.co/api/v2/"); //själva klienten alltså hemsidan där genom api all information hämtas.

            RestRequest request = new RestRequest("pokemon/bulbasaur"); //requestar information genom api från denna karaktär som skrivs
            
            IRestResponse response = client.Get(request); //innebär att man använder klienten för att hämta (get) själva requesten genom RestClient ovan
            
            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(response.Content); //innebär att man utgår från klassen Pokemon och skapar en instans av klassen. Hämtar då nödvändig information från api genom klassen.

            Console.WriteLine(pokemon.name + " valdes!");

            Console.WriteLine("Nu, skriv in en Pokemon karaktär!");
            //string namn = Console.ReadLine();
            
            RestRequest request2 = new RestRequest(/*"pokemon/namn"*/); //här kan användaren requesta vilken pokemon den vill utifrån api databasen. 
            
            IRestResponse response2 = client.Get(request2); //innebär att man använder klienten för att hämta (get) själva requesten genom RestClient ovan
            
            Fighter spelare = JsonConvert.DeserializeObject<Fighter>(response2.Content); //innebär att man utgår från klassen Pokemon och skapar en instans av klassen. Hämtar då nödvändig information från api genom klassen.

            Console.WriteLine("Du valde: " + spelare.name);
            Console.ReadLine();
            
            //gör att arenan är en klass. 

            Random generator = new Random();

            int damage = generator.Next(0, 5);

            //presentera fighter och skriv in klassen person här. 

            Fighter fighter = new Fighter(); //skapar fighter från klass Fighter
            
            
            Console.WriteLine(fighter.namn); //tilltalar att man ska skriva in namn på sin fighter.

            {
                fighter.namn = Console.ReadLine(); //här får man skriva in namn på sin fighter. Eftersom att fighter klass redan har namn tillgivit kan jag ta namn stringen därifrån
            };

            Console.WriteLine("" + fighter.namn + "!"); //skriver ut namnet. 
            
            Console.WriteLine(fighter.namn + " aka " + pokemon.name + "!"); //inkluderar även från klassen pokemon.name som användes längre upp
            
            Console.WriteLine("Nu börjar fighten! ");


            Console.ReadLine();








        }
    }
}
