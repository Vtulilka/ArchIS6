using Lab6.Controllers;
using System;
using System.Collections.Generic;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Controllers.DataBaseController dbController = new Controllers.DataBaseController();
            Controllers.HtmlController htmlController = new Controllers.HtmlController();

            List<Models.Pokemons> pokemons;

            try
            {
                pokemons = htmlController.GetPokemons();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Для завершения работы нажмите на любую кнопку");
                Console.ReadKey();
                return;
            }

            foreach (Models.Pokemons pokemon in pokemons)
            {
                Console.WriteLine(pokemon.Name);
                Console.WriteLine(pokemon.Type);
                Console.WriteLine();

                dbController.Insert(pokemon);
            }

            Console.WriteLine("Для завершения работы нажмите на любую кнопку");
            Console.ReadKey();

            
        }
    }
}
