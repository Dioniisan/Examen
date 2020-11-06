using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CifradoPokemon
{
    public class RandomNombre
    {
        public static string Randomizer()
        {
            string[] Pokemons =
            {
                "CHARIZARD",
                "SQUIRTLE",
                "REGICE",
                "GIRATINA",
                "GARDEVOIR"
            };

            Random random = new Random();

            int index = random.Next(Pokemons.Length);

            return $"{Pokemons[index]}";

        }
    }
}